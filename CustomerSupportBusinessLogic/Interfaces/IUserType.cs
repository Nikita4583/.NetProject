using CustomerSupportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupportBusinessLogic.Interfaces
{
    public interface IUserType
    {
        bool Insert(UserTypeViewModel model);
    }
}
