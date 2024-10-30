using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CART_management_system
{
   
            public class Program
        {
            public static void Main(string[] args)
            {
                var cart = new Cart();
                cart.AddItem(new Item("Laptop", 1, 1000m));
                cart.AddItem(new Item("Mouse", 2, 25m));

                var billingService = new BillingService(cart);

                // Apply a 10% discount
                billingService.SetDiscountStrategy(new PercentageDiscount(10));
                Console.WriteLine("Total with 10% discount: " + billingService.GetTotalAmount());

                // Apply a fixed discount of $50
                billingService.SetDiscountStrategy(new FixedDiscount(50));
                Console.WriteLine("Total with $50 discount: " + billingService.GetTotalAmount());
            }
        }

    }


