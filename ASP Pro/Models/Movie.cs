using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Pro.Models
{
    public class Movie
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}