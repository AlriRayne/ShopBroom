using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopBroom.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Tarot"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Accessories"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Gemstones"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Herbs"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Children of Litha Tarot Deck",
                    Description = "Everyday tarot deck.",
                    ImagePath= "tarotcard.png",
                    UnitPrice = 25.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Classic Rider-Waite Tarot Deck",
                    Description = "Everyday tarot deck.",
                    ImagePath= "tarotcard.png",
                    UnitPrice = 25.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Black Velvet Pouch",
                    Description = "A protective draw string pouch suitable for tarot decks and accessories.",
                    ImagePath= "pouch.png",
                    UnitPrice = 6.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Brown Leather Pouch",
                    Description = "A protective draw string pouch suitable for tarot decks and accessories.",
                    ImagePath= "pouch.png",
                    UnitPrice = 6.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Gems Assorted - 5pk",
                    Description = "A random selection of 5 gemstones.",
                    ImagePath= "gemstone.png",
                    UnitPrice = 10.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Gems Assorted - 10pk",
                    Description = "A random selection of 10 gemstones.",
                    ImagePath= "gemstone.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Apothecary Starter Kit",
                    Description = "A sample kit of 20 different herbs.",
                    ImagePath= "herbs.png",
                    UnitPrice = 30.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "French Lavender - 4 oz",
                    Description = "A 4 oz pack of dried French lavender flowers.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Calendula - 4 oz",
                    Description = "A 4 oz pack of dried calendula flowers.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Chamomile - 4 oz",
                    Description = "A 4 oz pack of dried chamomile flowers.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Lemon Balm - 4 oz",
                    Description = "A 4 oz pack of dried lemon balm leaves.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Peppermint - 4 oz",
                    Description = "A 4 oz pack of dried peppermint leaves.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Red Raspberry Leaf",
                    Description = "A 4 oz pack of dried red raspberry leaves.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Stinging Nettle - 4 oz",
                    Description = "A 4 oz pack of dried stinging nettle leaves.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Holy Basil - 4 oz",
                    Description = "A 4 oz pack of dried holy basil leaves.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Rosemary - 4 oz",
                    Description = "A 4 oz pack of dried rosemary leaves.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Rose Petals - 4 oz",
                    Description = "A 4 oz pack of dried pink rose petals.",
                    ImagePath= "herbs.png",
                    UnitPrice = 5.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "Wheel of the Year Altar Cloth",
                    Description = "Altar cloth depicting the Wheel of the Year.",
                    ImagePath= "cloth.png",
                    UnitPrice = 15.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 19,
                    ProductName = "Goddess Altar Cloth",
                    Description = "Altar cloth depicting the symbol of The Goddess.",
                    ImagePath= "cloth.png",
                    UnitPrice = 15.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 20,
                    ProductName = "Altar Candle Set - White",
                    Description = "A set of 4 white altar candles.",
                    ImagePath= "candles.png",
                    UnitPrice = 8.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 21,
                    ProductName = "Altar Candle Set - Color",
                    Description = "A set of 4 colored altar candles.",
                    ImagePath= "candles.png",
                    UnitPrice = 8.00,
                    CategoryID = 2
                }
            };

            return products;
        }
    }
}