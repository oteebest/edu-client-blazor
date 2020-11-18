using CBTClient.Util;
using CBTClientUnitTest.Data;
using System;
using Xunit;

namespace CBTClientUnitTest
{
    public class UnitTest1
    {



        [Theory]
        [MemberData(nameof(TestData.GetPagerInputData),
             MemberType = typeof(TestData))]
        public void TestPager(int totalSize, int pageSize, int pageNumber, int maximumPagesAllowed)
        {

            //act
            var pagerDetails = Utility.GetPagerDetails(totalSize,pageSize, pageNumber , maximumPagesAllowed);

           
            //assert
            Assert.False(pagerDetails.NextEnabled, "Failed Next Enabled");

            //assert
            Assert.False(pagerDetails.PreviousEnabled, "Failed Previous Enabled");


            //assert
            Assert.Equal(0, pagerDetails.PagerStartIndex);

            //assert
            Assert.Equal(3, pagerDetails.PagerEndIndex);

            //assert
            Assert.Equal(pageNumber - 1, pagerDetails.CurrentIndex);

        }


        [Theory]
        [MemberData(nameof(TestData.GetPagerInputData2),
           MemberType = typeof(TestData))]
        public void TestPager2(int totalSize, int pageSize, int pageNumber, int maximumPagesAllowed)
        {

            //act
            var pagerDetails = Utility.GetPagerDetails(totalSize, pageSize, pageNumber, maximumPagesAllowed);

            //assert
            Assert.False(pagerDetails.NextEnabled,"Failed Next Enabled");

            //assert
            Assert.False(pagerDetails.PreviousEnabled, "Failed Previous Enabled");

            //assert
            Assert.Equal(0, pagerDetails.PagerStartIndex);

            //assert
            Assert.Equal(2, pagerDetails.PagerEndIndex);

            //assert
            Assert.Equal(pageNumber - 1, pagerDetails.CurrentIndex);

        }

        [Theory]
        [MemberData(nameof(TestData.GetPagerInputData3),
       MemberType = typeof(TestData))]
        public void TestPager3(int totalSize, int pageSize, int pageNumber, int maximumPagesAllowed)
        {

            //act
            var pagerDetails = Utility.GetPagerDetails(totalSize, pageSize, pageNumber, maximumPagesAllowed);


            //assert
            Assert.True(pagerDetails.NextEnabled, "Failed Next Enabled");

            //assert
            Assert.True(pagerDetails.PreviousEnabled, "Failed Previous Enabled");


            //assert
            Assert.Equal(10, pagerDetails.PagerStartIndex);

            //assert
            Assert.Equal(14, pagerDetails.PagerEndIndex);

            //assert
            Assert.Equal(pageNumber - 1, pagerDetails.CurrentIndex);

        }


    }
}
