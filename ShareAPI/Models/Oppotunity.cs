using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShareAPI.Models
{
    public class Oppotunity
    {

        public int id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Organisation { get; set; }
        public string Venue { get; set; }
        public string Eligibility { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }



        //public string  Featured_image { get; set; }

        //public HttpPostedFileBase Featured_image_data { get; set; }
        public string OppotunityLink { get; set; }
        public string Benefits { get; set; }



        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        // Foreign Key 
        public int CategoryID { get; set; }
        //Navigation property
        public Category Category { get; set; }
    }

    //  public class ImageSource


}

    