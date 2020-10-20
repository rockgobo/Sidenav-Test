using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NepsSidenav.Model
{
    public class MenuNode
    {
        public List<MenuNode> Children { get; set; }
        public bool Selected { get; set; }
        public bool Last { get; set; }
        public bool First { get; set; }
        public bool Enabled { get { return true; } }
        public bool Breadcrumb { get; set; }
        public int Depth { get; set; }
        public string Id { get; set; }
        public string Url{ get {return "#";} }
        public string Text { get { return "Langer Nodename "  + Depth + "-" + Id + " " + " "+ (Selected?" (Selected)": "") + (Breadcrumb ? " (Bread)" : ""); } }
    }
}
