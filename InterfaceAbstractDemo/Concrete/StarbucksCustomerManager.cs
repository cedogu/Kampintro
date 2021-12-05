using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {

        ICustomerCheckService _customercheckService;

        public StarbucksCustomerManager (ICustomerCheckService customerCheckService)
        {
            _customercheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customercheckService.CheckIfRealPerson(customer))
            {
              base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }


    }
}
