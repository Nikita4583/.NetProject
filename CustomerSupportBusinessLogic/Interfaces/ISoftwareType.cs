using CustomerSupportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupportBusinessLogic.Interfaces
{
    public interface ISoftwareType
    {
        bool Insert(SoftwareTypeViewModel model);
    }
}
