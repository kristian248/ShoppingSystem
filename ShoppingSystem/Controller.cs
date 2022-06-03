using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSystem;

namespace ShoppingSystem
{
    public class Controller
    {
        public Controller()
        {
        }
        public string ProcessProductCommand(List<string> args)
        {
            PhysicalProduct product = new PhysicalProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
            return product.ToString(); 
        }
        public string ProcessServiceCommand(List<string> args)
        {
            ServiceProduct product = new ServiceProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
            return product.ToString();
        }
        public string ProcessCheckoutCommand(List<string> args)
        {
            Receipt receipt = new Receipt(args[0]);
            return null;
        }
        public string ProcessInfoCommand(List<string> args)
        {
            // TODO: Implement me...
            return null;
        }
        public string ProcessEndCommand()
        {
            // TODO: Implement me...
            return null;
        }

    }
}
