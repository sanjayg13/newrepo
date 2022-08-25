using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SampleWpfApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Qunatity { get; set; }
    }

    public class ProductData
    {
        const string file = @"C:\Users\320063801\OneDrive - Philips\Desktop\WPFTRAINING\SampleWpfApp\SampleWpfApp\Data.xml";
        private List<Product> _products = new List<Product>();
        public ProductData()
        {
            _products.Add(new Product
            {
                ProductID = 981,
                ProductName = "Casio",
                Image = @"Images\Casio.jpg",
                Qunatity = 1,
                Price = 7999
            }
              ) ;
            _products.Add(new Product
            {
                ProductID = 982,
                ProductName = "Diesel",
                Image = @"Images\Diesel.jpg",
                Qunatity = 1,
                Price = 5999
            }
             );
            _products.Add(new Product
            {
                ProductID = 983,
                ProductName = "Fastrack",
                Image = @"Images\Fastrack.jpg",
                Qunatity = 1,
                Price = 3999
            }
             );
            _products.Add(new Product
            {
                ProductID = 984,
                ProductName = "Fossil",
                Image = @"Images\Fossil.jpg",
                Qunatity = 1,
                Price = 1999
            }
             );
            _products.Add(new Product
            {
                ProductID = 985,
                ProductName = "Gucci",
                Image = @"Images\Gucci.jpg",
                Qunatity = 1,
                Price = 999
            });
            _products.Add(new Product
            {
                ProductID = 986,
                ProductName = "Guess",
                Image = @"Images\Guess.jpg",
                Qunatity = 1,
                Price = 4999
            }
             );
            _products.Add(new Product
            {
                ProductID = 987,
                ProductName = "Hamilton",
                Image = @"Images\Hamilton.jpg",
                Qunatity = 1,
                Price = 999
            }
             );
            _products.Add(new Product
            {
                ProductID = 988,
                ProductName = "Hublot",
                Image = @"Images\Hublot.jpg",
                Qunatity = 1,
                Price = 1499
            }
             );
            _products.Add(new Product
            {
                ProductID = 989,
                ProductName = "Omega",
                Image = @"Images\Omega.jpg",
                Qunatity = 1,
                Price = 699
            }
             );
            if (!File.Exists(file))
                Serialize();
            else
                deSerialize();
        }
       private void Serialize()
        {
            FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            xml.Serialize(fs, _products);
            fs.Close();
        }
        private void deSerialize()
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            _products = xml.Deserialize(fs) as List<Product>;
            fs.Close();
        }
        public List<Product> AllProducts => _products;
    }
}
