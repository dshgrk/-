using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗнижкоСвіт
{
    public class Card : IComparable<Card>
    {
        private int id;
        private string name;
        private string address;
        private int price;
        private int discount;
        private string imagePath;
        public bool IsFavorite { get; set; }

        public int Id
        {
            get { return id; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id must be a positive integer.");
                }
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address cannot be empty.");
                }
                address = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be greater than 0.");
                }
                price = value;
            }
        }

        public int Discount
        {
            get { return discount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Discount must be greater than 0.");
                }
                discount = value;
            }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Image path cannot be empty.");
                }
                imagePath = value;
            }
        }

        public Card(int id, string name, string address, int price, int discount, string imagePath)
        {
            Id = id;
            Name = name;
            Address = address;
            Price = price;
            Discount = discount;
            ImagePath = imagePath;
        }

        //логіка порівняння карти з іншою карткою за їхнім ім'ям
        public int CompareTo(Card other)
        {
            if (other == null)
                return 1;

            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

    }
}
