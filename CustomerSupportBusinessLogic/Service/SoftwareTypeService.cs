using CustomerSupportBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerSupportModel;
using CustomerSupportEntity;

namespace CustomerSupportBusinessLogic.Service
{
    public class SoftwareTypeService : ISoftwareType
    {
       bool ISoftwareType.Insert(SoftwareTypeViewModel model)
        {
            using (var ent = new CustomerSupportEntities())
            {
                var newRow = new tblSoftwareType();
                newRow.SoftwareTypeName = model.SoftwareTypeName;
                ent.tblSoftwareTypes.Add(newRow);
                int success = ent.SaveChanges();
                if (success > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
