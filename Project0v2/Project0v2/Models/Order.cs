using System;
using System.Collections.Generic;
using System.Text;

namespace Project0v2.Models
{
    public class Order
    {
        private int _OrderID;

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

        // Order details
        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        private decimal _Price;

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public Client Customer { get; set; }

        public Location Location { get; set; }

        public DateTime OrderDate { get; set; }

        public Order() { }

        public Order(Client Customer, Location Location)
        {
            this.Customer = Customer;
            this.Location = Location;
        }
        public override String ToString()
        {
            return $"{OrderID}) {Customer} at {Location} \tPrice: {Price} \tQuantity: {Quantity} - ordered {OrderDate}";
        }
    }
}
