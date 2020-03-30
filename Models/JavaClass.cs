using System.Collections.Generic;
using static APCRM.Models.Enums;

namespace APCRM.Models
{
    class JavaClass
    {
        string name;
        private List<Antipattern> antipatterns;
        private ClassRole role;

        public JavaClass(string name)
        {
            this.name = name;
            antipatterns = new List<Antipattern>();
        }
    }
}
