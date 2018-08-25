using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonsDenAPI.Helper
{
    public class SQLHelper
    {
        public static List<wt_binary_prediction2> GetBinaryResults(int ID)
        {
            using (var context = new DragonsDen2Entities())
            {
                return context.wt_binary_prediction2.Where(c => c.test_id == ID).ToList();                
            }
        }

        public static List<wt_regression_prediction> GetRegressionResults(int ID)
        {
            using (var context = new DragonsDen2Entities())
            {
                return context.wt_regression_prediction.Where(c => c.test_id == ID).ToList();
            }
        }

    }
}