using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Property
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return string.Format("{0}: {1}", Title, Description);
        }
    }

    public class Skills : Property
    {
        public int Precentage { get; set; }
        public override string ToString()
        {
            return string.Format("{0}: {1}% \n{2}", Title, Precentage, Description);
        }
    }

    public class Jobs : Property { }
    public class Experience : Property{ }
}
