﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace QQSpace
{

    public partial class UploadImageData
    {
        public class Data2
        {
            public string albumid { get; set; }
            public int contentlen { get; set; }
            public int height { get; set; }
            public int limitpic { get; set; }
            public string lloc { get; set; }
            public string pre { get; set; }
            public string sloc { get; set; }
            public int totalpic { get; set; }
            public int type { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }
    }

    public partial class UploadImageData
    {
        public Data2 data { get; set; }
        public int ret { get; set; }
    }

}
