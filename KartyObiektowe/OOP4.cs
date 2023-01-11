using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cash : Payment
    {
        private float cashTendered;
    }
    class Check : Payment
    {
        private string name;
        private string bankID;
        public void authorized()
        {
            Console.WriteLine("Authorized");
        }
    }
    class Credit : Payment
    {
        private string name;
        private string type;
        private int expDate;
        public void authorized()
        {
            Console.WriteLine("Authorized");
        }
    }
    class Customer
    {
        private string name;
        private string adress;
    }
    class Item
    {
        private int shippingWeight;
        private string description;
        public int getPriceForQuantity()
        {
            return shippingWeight;
        }
        public string getTax()
        {
            return description;
        }
        public void inStock()
        {
            Console.WriteLine("everything is in stock");
        }
    }
    class OrderDetail
    {
        private string quality;
        private string taxStatus;
        private Order order;
        public void calcSubTotal()
        {

        }
        public void calcWeight()
        {
            
        }
        public void calcTax()
        {
            
        }
        public void setOrderDetail(Order aorder)
        {
            this.order = aorder;
        }
    }
    class Payment
    {
        private float amount;
    }
    class Order
    {
        private string Status;
        private DateTime date;
        public void calcSubTotal()
        {

        }
        public void calcTotalWeight()
        {

        }
        public void calcTax()
        {
            Console.WriteLine("obliczam");
        }
        public void calcTotal()
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cash ca1 = new Cash();
            Check ch1 = new Check();
            ch1.authorized();
            Credit cr1 = new Credit();
            cr1.authorized();
            OrderDetail orD1 = new OrderDetail();
            Order or1 = new Order();
            or1.calcTax();


            Console.ReadKey();
        }
    }
}
