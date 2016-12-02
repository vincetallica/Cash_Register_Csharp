using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterNS
{
    public class Product
    {
        protected string  m_product_name;
        protected decimal m_amount;
        protected decimal m_price;

        protected bool m_sw = false; //Singlar or Weight Product, singular=false
        protected bool m_discount = false;

        private Product()
        {

        }
        public Product (string ProductName, bool sw, decimal productPrice, decimal amount)
        {
            m_product_name = ProductName;
            m_sw = sw;
            m_price = productPrice;
            m_amount = amount;
        }
        public Product(string ProductName, bool sw, bool discount, decimal productPrice, decimal amount)
        {
            m_product_name = ProductName;
            m_sw = sw;
            m_discount = discount;
            m_price = productPrice;
            m_amount = amount;
        }
        public decimal getPrice()
        {
            return m_price;
        }
        public decimal getAmount()
        {
            return m_amount;
        }
        
    }

    public class CashRegister
    {
        private List<Product> productList;
        public CashRegister()
        {
            productList = new List<Product>();
        }

        public void addItem(Product item)
        {
            productList.Add(item);
        }

        public void removeItem(Product item)
        {
            productList.Remove(item);
        }

        public decimal calculateTot()
        {
            decimal total = 0;
            foreach (Product item in productList)
            {
                total += item.getAmount() * item.getPrice();
            }
            return total;
        }
        public void removeAll()
        {
            productList.Clear();
        }
    }
}
