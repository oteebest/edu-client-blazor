using CBTClientUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBTClientUnitTest.Data
{
    public class TestData
    {

        public static IEnumerable<object[]> GetPagerInputData
        {
            get
            {
               //  int totalSize, int pageSize, int pageNumber, int maximumPagesAllowed
                return new List<object[]> { new object[] { 12,3,4,5 } };
            }
           
        }

        public static IEnumerable<object[]> GetPagerInputData2
        {
            get
            {
                //  int totalSize, int pageSize, int pageNumber, int maximumPagesAllowed
                return new List<object[]> { new object[] { 25, 10, 2, 5 } };
            }

        }


        public static IEnumerable<object[]> GetPagerInputData3
        {
            get
            {
                //  int totalSize, int pageSize, int pageNumber, int maximumPagesAllowed
                return new List<object[]> { new object[] { 110, 3, 15, 5 } };
            }

        }

    }
}
