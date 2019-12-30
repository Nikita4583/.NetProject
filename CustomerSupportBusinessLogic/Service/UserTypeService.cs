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
    public class UserTypeService : IUserType
    {
       bool IUserType.Insert(UserTypeViewModel model)
        {
            using (var ent = new CustomerSupportEntities())
            {
                var newRow = new tblUserType();
                newRow.UserTypeName = model.UserTypeName;
                newRow.UserTypes.Add(newRow);
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
