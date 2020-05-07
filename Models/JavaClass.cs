using System.Collections.Generic;

namespace APCRM.Models
{
    class JavaClass
    {
        public string name;
        public List<string> aps;
        public string classRole;

        public string shortName;

        public JavaClass(string name)
        {
            this.name = name;
            aps = new List<string>();
        }
    }
}
