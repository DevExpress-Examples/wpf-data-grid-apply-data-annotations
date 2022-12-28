using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Apply_Data_Annotations {
    public enum Countries {
        [Image("pack://application:,,,/Images/at.png")]
        Austria,
        [Image("pack://application:,,,/Images/br.png")]
        Brazil,
        [Image("pack://application:,,,/Images/de.png")]
        Germany,
        [Image("pack://application:,,,/Images/it.png")]
        Italy,
        [Image("pack://application:,,,/Images/mx.png")]
        Mexico,
        [Image("pack://application:,,,/Images/gb.png")]
        UK,
        [Image("pack://application:,,,/Images/us.png")]
        USA
    }
    public class Product {
        [Editable(false)]
        public int Id { get; set; }
        [Display(Name = "Product")]
        public string ProductName { get; set; }
        [GridEditor(TemplateKey = "comboBox")]
        public Enum Country { get; set; }
        [Required]
        public string City { get; set; }
        [NumericMask(Mask = "c", UseAsDisplayFormat = true)]
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "yyyy-MMM-dd dddd")]
        public DateTime OrderDate { get; set; }
        [Display(AutoGenerateField = false, Description = "This column is not created.")]
        public string AdditionalInfo { get; set; }
    }
    public class Products {
        public static ObservableCollection<Product> GetProducts() {
            var products = new ObservableCollection<Product> {
                new Product() {
                    Id = 0, ProductName = "Chang", Country = Countries.UK, City = "Cowes",
                    UnitPrice = 19, Quantity = 10, OrderDate = new DateTime(2021, 10, 23)
                },
                new Product() {
                    Id = 1, ProductName = "Gravad lax", Country = Countries.Italy, City = "Reggio Emilia",
                    UnitPrice = 12.5, Quantity = 16, OrderDate = new DateTime(2021, 10, 22)
                },
                new Product() {
                    Id = 2, ProductName = "Ravioli Angelo", Country = Countries.Brazil, City = "Rio de Janeiro",
                    UnitPrice = 19, Quantity = 12, OrderDate = new DateTime(2021, 10, 21)
                },
                new Product() {
                    Id = 3, ProductName = "Tarte au sucre", Country = Countries.Germany, City = "Leipzig",
                    UnitPrice = 22, Quantity = 50, OrderDate = new DateTime(2021, 10, 15)
                },
                new Product() {
                    Id = 4, ProductName = "Steeleye Stout", Country = Countries.USA, City = "Denver",
                    UnitPrice = 18, Quantity = 20, OrderDate = new DateTime(2021, 10, 8)
                },
                new Product() {
                    Id = 5, ProductName = "Pavlova", Country = Countries.Austria, City = "Graz",
                    UnitPrice = 21, Quantity = 52, OrderDate = new DateTime(2021, 10, 1)
                },
                new Product() {
                    Id = 6, ProductName = "Longlife Tofu", Country = Countries.USA, City = "Boise",
                    UnitPrice = 7.75, Quantity = 120, OrderDate = new DateTime(2021, 9, 17)
                },
                new Product() {
                    Id = 7, ProductName = "Alice Mutton", Country = Countries.Mexico, City = "México D.F.",
                    UnitPrice = 21, Quantity = 15, OrderDate = new DateTime(2021, 9, 25)
                }
            };
            return products;
        }
    }
}