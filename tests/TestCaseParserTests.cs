using NUnit.Framework;
using tcms.Domain;

namespace tcms.tests
{
	public class TestCaseParserTests
	{
		[Test]
		public void VeryBasicTest()
		{
			var results = TestCaseWikiParser.Parse(@"
# Designer

## TestCase: Displays the blank report after ""New"" command
This scenario verifies proper initialization of the designer web component....

@type: Functional
@priority: High
@estimateHr: 0
@automated

### Repro steps
1. create blank form
2. drop designer component
3. start the project (press F5)

### Expected
The blank surface is shown
			");

			Assert.That(results, Has.Count.EqualTo(1));

			var result = results[0];
			Assert.That(result.Title, Is.EqualTo(@"Displays the blank report after ""New"" command"));
			
			StringAssert.StartsWith("This scenario verifies", result.Text);
			StringAssert.EndsWith("blank surface is shown", result.Text);

			Assert.That(result.Project, Is.EqualTo("Designer"));
			Assert.That(result.ComponentPath, Is.EqualTo(""));
			Assert.That(result.Type, Is.EqualTo("Functional"));
			Assert.That(result.Priority, Is.EqualTo("High"));
			Assert.That(result.EstimateHr, Is.EqualTo(0.0));
			Assert.That(result.Automated, Is.True);
		}

		[Test]
		public void ParseTestCaseId()
		{
			var results = TestCaseWikiParser.Parse(@"### TestCase: t {id=1233}");
			Assert.That(results, Has.Count.EqualTo(1));
			Assert.That(results[0].Title, Is.EqualTo("t"));
			Assert.That(results[0].Id, Is.EqualTo("1233"));
		}

		[Test]
		public void ComponentPathTest()
		{
			var results = TestCaseWikiParser.Parse(@"
# Designer
## Surface
### TestCase: t

@type: Functional
");

			Assert.That(results, Has.Count.EqualTo(1));
			Assert.That(results[0].Project, Is.EqualTo("Designer"));
			Assert.That(results[0].ComponentPath, Is.EqualTo("Surface"));
		}

		[Test]
		public void ComponentPathTest2()
		{
			var results = TestCaseWikiParser.Parse(@"
# Designer
## Surface
## TestCase: t

@type: Functional
");

			Assert.That(results, Has.Count.EqualTo(1));
			Assert.That(results[0].Project, Is.EqualTo("Designer"));
			Assert.That(results[0].ComponentPath, Is.EqualTo(""));
		}

		[Test]
		public void ComponentPathTest3()
		{
			var results = TestCaseWikiParser.Parse(@"
# Designer
## Surface
### Grid
### TestCase: t

@type: Functional
");

			Assert.That(results, Has.Count.EqualTo(1));
			Assert.That(results[0].Project, Is.EqualTo("Designer"));
			Assert.That(results[0].ComponentPath, Is.EqualTo("Surface"));
		}

		[Test]
		public void ComponentPathTest4()
		{
			var results = TestCaseWikiParser.Parse(@"
# Designer
## Surface
### Grid
#### TestCase: 1
### TestCase: 2

@type: Functional
");

			Assert.That(results, Has.Count.EqualTo(2));
			Assert.That(results[0].Project, Is.EqualTo("Designer"));
			Assert.That(results[0].ComponentPath, Is.EqualTo("Surface/Grid"));
			Assert.That(results[1].Project, Is.EqualTo("Designer"));
			Assert.That(results[1].ComponentPath, Is.EqualTo("Surface"));
		}

		[Test]
		public void MultipleTestCases()
		{
			var results = TestCaseWikiParser.Parse(@"
# Designer
## Surface
### TestCase: 1
@priority: low

## Properties
### TestCase: 2
@priority: high
");

			Assert.That(results, Has.Count.EqualTo(2));
			Assert.That(results[0].Project, Is.EqualTo("Designer"));
			Assert.That(results[0].ComponentPath, Is.EqualTo("Surface"));
			Assert.That(results[0].Priority, Is.EqualTo("low"));
			Assert.That(results[1].Project, Is.EqualTo("Designer"));
			Assert.That(results[1].ComponentPath, Is.EqualTo("Properties"));
			Assert.That(results[1].Priority, Is.EqualTo("high"));
		}
	}
}