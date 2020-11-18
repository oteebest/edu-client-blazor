using System;
using System.Collections.Generic;
using System.Text;

namespace CBTClientUnitTest.Model
{
    public class PagerInputModel
    {
        public int TotalSize { get; set; } = 12;
        public int PageSize { get; set; } = 1;
        public int PageNumber { get; set; } = 4;
    }
}
