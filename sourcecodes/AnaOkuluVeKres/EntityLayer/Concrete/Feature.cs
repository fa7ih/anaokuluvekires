using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        public string FeatureHeadTitle { get; set; }
        public string FeatureTitle1 { get; set; }
        public string FeatureTitle2 { get; set; }
        public string FeatureTitle3 { get; set; }
        public string FeatureTitle4 { get; set; }
        public string FeatureDescription1 { get; set; }
        public string FeatureDescription2 { get; set; }
        public string FeatureDescription3 { get; set; }
        public string FeatureDescription4 { get; set; }
    }
}
