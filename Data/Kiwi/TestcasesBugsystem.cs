﻿using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestcasesBugsystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ApiUrl { get; set; }
        public string ApiPassword { get; set; }
        public string ApiUsername { get; set; }
        public string TrackerType { get; set; }
        public string BaseUrl { get; set; }
    }
}
