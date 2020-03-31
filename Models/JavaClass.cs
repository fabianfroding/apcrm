using System.Collections.Generic;
using static APCRM.Models.Enums;

namespace APCRM.Models
{
    class JavaClass
    {
        public string name;
        public List<Antipattern> antipatterns;
        public ClassRole role;

        public JavaClass(string name)
        {
            this.name = name;
            antipatterns = new List<Antipattern>();
        }
    }
}
