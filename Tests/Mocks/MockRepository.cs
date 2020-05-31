using JoeCoffeeStore.StockManagement.DAL;
using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Mocks
{
    public class MockRepository : ICoffeeRepository
    {
        public void DeleteCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }

        public Coffee GetACoffee()
        {
            throw new NotImplementedException();
        }

        public Coffee GetCoffeeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Coffee> GetCoffees()
        {
            throw new NotImplementedException();
        }

        public void UpdateCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }
    }
}
