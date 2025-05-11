using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete {
    public class AboutUs {
        public int AboutUsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        //public List<AboutUsDescriptionSubItem> DescriptionSubItems { get; set; }

        /*
        public class AboutUsDescriptionSubItem {
            public int AboutUsDescriptionSubItemId { get; set; }
            public string Content { get; set; }
        }
        */
    }
}
