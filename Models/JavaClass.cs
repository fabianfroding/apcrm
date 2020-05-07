using System.Collections.Generic;

namespace APCRM.Models
{
    class JavaClass
    {
        public string name;
        public string shortName;
        public List<string> aps;
        public string classRole;

        public JavaClass(string name)
        {
            this.name = name;
            aps = new List<string>();
        }
    }
}
