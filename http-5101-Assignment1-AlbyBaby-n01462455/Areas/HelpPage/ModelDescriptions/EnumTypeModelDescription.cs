using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace http_5101_Assignment1_AlbyBaby_n01462455.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}