//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DragonsDenAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class wt_regression_prediction
    {
        public int id { get; set; }
        public Nullable<int> test_id { get; set; }
        public Nullable<int> cycle { get; set; }
        public Nullable<double> Forest_Prediction { get; set; }
        public Nullable<double> Boosted_Prediction { get; set; }
        public Nullable<double> Poisson_Prediction { get; set; }
        public Nullable<double> Nnet_Prediction { get; set; }
    }
}
