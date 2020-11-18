
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Util
{
    public class Utility
    {

        public enum QuestionState
        {
            Question,
            Option,
            Done,
        }

        //public static PagerModel GetPagerDetails(int TotalSize, int PageSize, int PageNumber, int MaximumPages)
        //{
        //    int startIndex = 0;

        //    int endIndex = 0;

        //    int totalPages = 0;

        //    int currentIndex = PageNumber - 1;

        //    if (TotalSize > 0)
        //    {
        //        totalPages = (TotalSize / PageSize) + ( (TotalSize % PageSize) > 1 ? 1 : 0 );

        //        if(totalPages <= MaximumPages)
        //        {
        //            startIndex = 0;
        //            endIndex = totalPages - 1;                    
        //        }
        //        else
        //        {
        //            //  XXX + YYY = MaximumPages;
        //            if(PageNumber > MaximumPages)
        //            {
        //                startIndex = currentIndex - MaximumPages + 1;

        //                endIndex = currentIndex;
        //            }
        //            else
        //            {
        //                startIndex = 0;

        //                endIndex = MaximumPages - 1;
        //            }

                  
        //        }

        //    }

             
        //    return new PagerModel { CurrentIndex = currentIndex, 
        //        PagerStartIndex = startIndex, PagerEndIndex = endIndex,
        //        NextEnabled = endIndex + 1 < totalPages,
        //        PreviousEnabled = startIndex > 0,
                
        //    };

        //}

    }
}
