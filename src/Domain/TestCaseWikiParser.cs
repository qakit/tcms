using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace tcms.Domain
{
	public class ParsedTestCase
	{
		public string Id { get; set; }
		public string Text { get; set; }
		public string Title { get; set; }

		public string Project { get; set; }
		public string ComponentPath { get; set; }
		public float? EstimateHr { get; set; }
		public bool Automated { get; set; }

		public string Priority { get; set; }
		public string Type { get; set; }
	}

	public static class TestCaseWikiParser
	{
		const string TestCaseMarker = "testcase:";

		public static IList<ParsedTestCase> Parse(string text)
		{
			var result = new List<ParsedTestCase>();

			var document = Markdig.Markdown.Parse(text);

			var isTestCase = false;
			var testCaseHeadingLevel = 0;
			var testCaseAttributes = new List<string>();

			HeadingBlock startBlock = null;
			string[] breadcrumbs = new string[10];

			void writeTestCase(int endPosition)
			{
				var start = startBlock?.Span.End + 1 ?? 0;
				var caseText = endPosition > start ? text.Substring(start, endPosition - start) : text.Substring(start);

				var headingText = getHeadingText(startBlock).Substring(TestCaseMarker.Length);
				var (headingTitle, titleAttrs) = extractAttributes(headingText);

				var attributes = readAttributes(testCaseAttributes);
				string tryGetAttr(string name) => attributes.TryGetValue(name, out string v) ? v : null;
				float? tryGetAttrNum(string name) =>
					attributes.TryGetValue(name, out string v) && float.TryParse(v, out float result) ? result : null;

				var projectName = breadcrumbs.FirstOrDefault() ?? "";
				var componentPath = string.Join('/', breadcrumbs.Take(startBlock.Level - 1).Skip(1).Where(b => !string.IsNullOrWhiteSpace(b)).ToArray());

				result.Add(new () {
					Id = titleAttrs.TryGetValue("id", out var id) ? id : null,
					Text = caseText.Trim(),
					Title = headingTitle.Trim(),
					Project = projectName,
					ComponentPath = componentPath,
					Type = tryGetAttr("type"),
					Priority = tryGetAttr("priority"),
					EstimateHr = tryGetAttrNum("estimateHr"),
					Automated = tryGetAttr("automated") == "true",
				});
			}

			foreach (var block in document)
			{
				if (block is HeadingBlock h)
				{
					var headingTitle = getHeadingText(h);

					if (isTestCase && h.Level <= testCaseHeadingLevel)
					{
						writeTestCase(block.Span.Start);
						testCaseAttributes.Clear();
						isTestCase = false;
					}
					if (!isTestCase)
					{
						if (h.Level < breadcrumbs.Length)
						{
							breadcrumbs[h.Level - 1] = headingTitle;
							for(var i = h.Level; i < breadcrumbs.Length; i++) breadcrumbs[i] = null;
						}

						if (headingTitle.StartsWith(TestCaseMarker, StringComparison.InvariantCultureIgnoreCase))
						{
							isTestCase = true;
							testCaseHeadingLevel = h.Level;
							startBlock = h;
						}
					}
				}
				else if (block is ParagraphBlock p)
				{
					if (isTestCase)
					{
						collectAttributeDefinitions(p.Inline, testCaseAttributes);
					}
				}
			}
			if(isTestCase) {
				writeTestCase(-1);
			}
			return result;
		}

		private static IDictionary<string, string> readAttributes(IEnumerable<string> attributes) => (
				from a in attributes
				let parts = a.Split(':')
				let key = (parts[0].StartsWith('@') ? parts[0].Substring(1) : parts[0]).Trim()
				let value = parts.Length < 2 ? "true": parts[1].Trim()
				where !string.IsNullOrEmpty(key)
				select new { key, value }
			).ToDictionary(p => p.key, p => p.value, StringComparer.InvariantCultureIgnoreCase);

		private static void collectInlineText(Inline inline, StringBuilder builder)
		{
			if (inline is LiteralInline lit)
			{
				builder.Append(lit.Content.ToString());
			}
			else if (inline is ContainerInline container)
			{
				foreach (var item in container)
				{
					collectInlineText(item, builder);
				}
			}
		}

		private static string getHeadingText(HeadingBlock block)
		{
			if (block.Inline == null) return "";
			StringBuilder builder = new();
			collectInlineText(block.Inline, builder);

			return builder.ToString();
		}

		private static void collectAttributeDefinitions(Inline inline, List<string> result)
		{
			if (inline is LiteralInline lit)
			{
				var text = lit.Content.ToString().Trim();
				if (text.StartsWith('@')) result.Add(text);
			}
			else if (inline is ContainerInline container)
			{
				foreach (var item in container)
				{
					collectAttributeDefinitions(item, result);
				}
			}
		}

		private static readonly Regex attributesRegex = new Regex(@"{(\w+)=([^}]+)}\s*");

		private static (string, IDictionary<string, string>) extractAttributes(string data)
		{
			Dictionary<string, string> attrs = new (StringComparer.InvariantCultureIgnoreCase);
			var remStart = 0;
			var remainder = new StringBuilder();
			var result = attributesRegex.Matches(data);
			foreach(Match m in result)
			{
				remainder.Append(data.Substring(remStart, m.Index - remStart));
				remStart = m.Index + m.Length;
				attrs.Add(m.Groups[1].Value, m.Groups[2].Value);
			}
			remainder.Append(data.Substring(remStart));
			return (remainder.ToString(), attrs);
		}

	}
}
