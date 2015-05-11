using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnamiSushi.Models;

namespace UnamiSushi.DAL
{
    public class PrototypeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PrimaryContext>
    {
        protected override void Seed(PrimaryContext context)
        {
             var menuCategories = new List<MenuCategory>
            {
                new MenuCategory{CategoryName="Sushi-Burritos", CategoryDescription="Sushi combined into a burrito rice wrap"},
                new MenuCategory{CategoryName="Asian-Grill", CategoryDescription="Asian Grills are your traditional cooked japansese foods like teryaki, stir-fry, and curries"},
                new MenuCategory{CategoryName="Sushi-Rolls", CategoryDescription="Contains your classic california roll to special rolls"},
            };
            menuCategories.ForEach(s => context.MenuCategories.Add(s));
            context.SaveChanges();

            var subcategories = new List<Subcategory>
            {
                new Subcategory{SubcategoryName="Classic Sushidos", CategoryID=1, SubcategoryDescription="Based on classic sushi rolls"},//1
                new Subcategory{SubcategoryName="Premium Sushidos", CategoryID=1, SubcategoryDescription="Based on special sushi rolls"},//2
                new Subcategory{SubcategoryName="Veggie Sushidos", CategoryID=1, SubcategoryDescription="Sushidos for vegearians"},//3

                new Subcategory{SubcategoryName="Original Rolls",CategoryID=3, SubcategoryDescription="Classic simple rolls"},//4
                new Subcategory{SubcategoryName="Special Rolls", CategoryID=3, SubcategoryDescription="Sushi rolls with a twist"},//5
                new Subcategory{SubcategoryName="Tempura Rolls", CategoryID=3, SubcategoryDescription="Don't even know"},//6

                new Subcategory{SubcategoryName="Teryaki", CategoryID=2, SubcategoryDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rices"},
                new Subcategory{SubcategoryName="Stir-Fry", CategoryID=2, SubcategoryDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha "},
                new Subcategory{SubcategoryName="Japanese Curry", CategoryID=2, SubcategoryDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce"},
                new Subcategory{SubcategoryName="Sweet & Sour", CategoryID=2, SubcategoryDescription="Hand battered and tossed in our delicious sweet & sour sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles"},
                new Subcategory{SubcategoryName="General Tso’s", CategoryID=2, SubcategoryDescription="Hand battered and tossed in our delicious spicy General Tso’s sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with choice of steamed white rice or noodles"},
                new Subcategory{SubcategoryName="Orange", CategoryID=2, SubcategoryDescription="Stir-fried onions, mushroom, red bell peppers, and broccoli in our delicious ginger orange sauce. Served with choice of steamed white rice or noodles"},
            };
            subcategories.ForEach(s => context.Subcategories.Add(s));
            context.SaveChanges();

            var menuItems = new List<MenuItem>
            {
                // Classic Sushidos
                new MenuItem{SubcategoryID=1, MenuItemName="Califronia", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Surimi crab, avocado, cream cheese, cucumber, tempura flakes, carrot, seaweed salad, sweet soy reduction",
                MenuItemPrice= 8.95},
                new MenuItem{SubcategoryID=1, MenuItemName="Neptune", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Tempura calamri, spicy cream cheese, avacado, cucumber, tempura flakes, shredded carrot, seaweed salad, spicy sauce, sweet soy reduction",
                MenuItemPrice= 10.95},
                new MenuItem{SubcategoryID=1, MenuItemName="Spicy Tuna", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Avacado, cucumber, spicey tuna, tempura flakes, carrot, seaweed salad, spicy sauce, sweet soy reduction",
                MenuItemPrice= 12.95},
                new MenuItem{SubcategoryID=1, MenuItemName="Ginger Sake", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, grated ginger, tempura shrimp, avocado, cucumber, shredded carrot, seaweed salad, sesame ginger poke` sauce, sweet soy reduction",
                MenuItemPrice= 11.49},
                new MenuItem{SubcategoryID=1, MenuItemName="MGM", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Cream Cheese, avocado, fresh salmon, tempura asparagus, cucumber, pickled jalapeno, seaweed salad, carrot, sweet soy reduction, dynamite sauce",
                MenuItemPrice= 12.95},

                // Premium Sushidos
                new MenuItem{SubcategoryID=2, MenuItemName="Big Foot", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy cream cheese, spicy tuna, grilled gulf shrimp, surimi crab, tempura flakes, avocado, cucumber, seaweed salad, sweet garlic sauce, spicy sauce, sweet soy reduction",
                MenuItemPrice= 14.95},
                new MenuItem{SubcategoryID=2, MenuItemName="#Bacon", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Cream cheese, Roasted jalapeno, spicy tuna, fresh salmon, tempura Applewood smoked bacon, avocado, cucumber,  sriracha maple sauce",
                MenuItemPrice= 15.49},
                new MenuItem{SubcategoryID=2, MenuItemName="Mt. Hood", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Cream cheese, smoked salmon, tempura flakes, avocado, cucumber, surimi crab, seaweed salad, carrots, sweet wasabi sauce",
                MenuItemPrice = 15.49},
                new MenuItem{SubcategoryID=2, MenuItemName="Samurai", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, yellowtail, yellow fin tuna, and seared pacific albacore tuna sashimi, avocado, cucumber, tempura green onion, shaved red cabbage, refreshing lemon ginger vinegar",
                MenuItemPrice = 16.49},
                new MenuItem{SubcategoryID=2, MenuItemName="Caribbean", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Cream cheese, fresh salmon, coconut shrimp, avocado, cucumber, mango, coconut, sweet chili sauce",
                MenuItemPrice = 12.49},
                new MenuItem{SubcategoryID=2, MenuItemName="Black Widow", Piece=0, Cooked=false, Vegetarian=false, 
                MenuItemDescription="Sesame seared albacore tuna, grilled shrimp, surimi crab, spicy cream cheese, avocado, cucumber, shredded carrot, seaweed salad, dynamite sauce, sweet soy reduction",
                MenuItemPrice = 12.95},
                new MenuItem{SubcategoryID=2, MenuItemName="Ling Ling", Piece=0, Cooked=false, Vegetarian=false, 
                MenuItemDescription="Tempura soft shell crab, spicy cream cheese, fresh salmon, teriyaki eel, surimi crab, avocado, cucumber, shredded carrot, seaweed salad, sriracha, sweet soy reduction",
                MenuItemPrice = 16.49},
                new MenuItem{SubcategoryID=2, MenuItemName="M-80", Piece=0, Cooked=false, Vegetarian=false, 
                MenuItemDescription="Pepper seared ahi tuna, panko sea scallop, masago, roasted jalapeno, pickled jalapeno, avocado, cucumber, green onions, seaweed salad, spicy chili garlic sauce, spicy sauce ",
                MenuItemPrice = 15.49},
                new MenuItem{SubcategoryID=2, MenuItemName="Dan Klein", Piece=0, Cooked=false, Vegetarian=false,  
                MenuItemDescription="Half a pound of lemon pepper seared salmon, avocado, cucumber, grilled shrimp, pickled jalapeno, sweet soy reduction, sriracha, wrapped in seaweed",
                MenuItemPrice = 14.49},
                new MenuItem{SubcategoryID=2, MenuItemName="Panda", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Tempura shrimp, surimi crab, avocado, cucumber, carrot, seaweed salad, sweet garlic sauce, sweet soy reduction",
                MenuItemPrice = 12.49},
                new MenuItem{SubcategoryID=2, MenuItemName="Magic Cap", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy cream cheese, avocado, cucumber, crispy panko mushroom, spicy tuna, seaweed salad, carrot, sweet garlic sauce, sweet soy reduction",
                MenuItemPrice = 13.95},
                new MenuItem{SubcategoryID=2, MenuItemName="Caterpillar", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Cream cheese, teriyaki eel, tempura shrimp, surimi crab, avocado, cucumber, tempura flakes, seaweed salad, sweet soy reduction",
                MenuItemPrice = 15.49},

                //Veggie Sushidos
                new MenuItem{SubcategoryID=3, MenuItemName="Hipster", Piece=0, Cooked=false, Vegetarian=true,
                MenuItemDescription="Grilled asparagus, grilled mushrooms, red bell pepper, avocado, carrots, cucumber, pickled daikon radish, pickled burdock root, seaweed salad, sweet soy reduction, sweet garlic sauce",
                MenuItemPrice = 8.95},
                new MenuItem{SubcategoryID=3, MenuItemName="Sweet Deandra", Piece=0, Cooked=false, Vegetarian=true,
                MenuItemDescription="Tempura asparagus, cream cheese, avocado, cucumber, shredded carrot, seaweed salad, sweet soy reduction",
                MenuItemPrice = 8.49},

                // Sushi Rolls
                new MenuItem{SubcategoryID=4, MenuItemName="California", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Avocado, cucumber, crab cake",
                MenuItemPrice = 4.25},
                new MenuItem{SubcategoryID=4, MenuItemName="Philly", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, cream cheese, scallions, and cucumbers",
                MenuItemPrice = 4.25},
                new MenuItem{SubcategoryID=4, MenuItemName="Spicy Roll", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Choice of tuna, salmon,or scallop, and avocado",
                MenuItemPrice = 5.25},
                new MenuItem{SubcategoryID=4, MenuItemName="Ducks Roll", Piece=5, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura shrimp, masago & veggies w/ Japanese mayo",
                MenuItemPrice = 5.49},
                new MenuItem{SubcategoryID=4, MenuItemName="Assorted Veggie", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Avocado, cucumber, asparagus, scallion, carrots",
                MenuItemPrice = 3.95},
                new MenuItem{SubcategoryID=4, MenuItemName="Sweet Dee", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura asparagus, cream cheese, sweet soy reduction",
                MenuItemPrice = 3.95},
                new MenuItem{SubcategoryID=4, MenuItemName="Garden", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Cream cheese, asparagus, pickled burdock root, cucumber, pickled daikon radish, scallions, red bell pepper, avocado, garlic sauce",
                MenuItemPrice = 6.95},
                new MenuItem{SubcategoryID=4, MenuItemName="Squidward", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Spicy tempura fried calamari, scallions, masago, avocado",
                MenuItemPrice = 6.49},
                new MenuItem{SubcategoryID=5, MenuItemName="Trident", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura calamari, snow crab, spicy cream cheese, avocado, cucumber, scallions, spicy sauce",
                MenuItemPrice = 7.95},
                new MenuItem{SubcategoryID=5, MenuItemName="Florida", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Creamy scallop and avocado topped with fresh salmon, masago, and lemon zest",
                MenuItemPrice = 10.95},
                new MenuItem{SubcategoryID=5, MenuItemName="Super Panda", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura shrimp, avocado, cucumber, snow crab, topped with sweet roasted garlic sauce",
                MenuItemPrice = 8.49},
                new MenuItem{SubcategoryID=5, MenuItemName="Spider", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura soft shell crab, avocado, cucumber, tare,",
                MenuItemPrice = 8.95},
                new MenuItem{SubcategoryID=5, MenuItemName="Tiger", Piece=6, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy tuna, cucumber, topped with avocado, shrimp, tempura flakes, chili sauce, chili spices",
                MenuItemPrice = 10.95},
                new MenuItem{SubcategoryID=5, MenuItemName="Rainbow", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Snow crab, avocado, cucumber, top with 5 fish and mango sauce",
                MenuItemPrice = 13.49},
                new MenuItem{SubcategoryID=5, MenuItemName="Alaskan", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Hard Smoked salmon, cream cheese, cucumber, top w/avocado, salmon and sweet wasabi sauce",
                MenuItemPrice = 12.49},
                new MenuItem{SubcategoryID=5, MenuItemName="Dynamite", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Tempura shrimp, cucumber, top with avocado, yellowtail, spicy tuna, jalapeño, dynamite sauce",
                MenuItemPrice = 15.95},
                new MenuItem{SubcategoryID=5, MenuItemName="Atlantis", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Tempura soft shell crab topped with avocado, fresh salmon, eel, snow crab, and spicy tare` sauce",
                MenuItemPrice = 16.49},
                new MenuItem{SubcategoryID=5, MenuItemName="Electric Eel", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Tempura eel, sea scallop, topwith avocado, snow crab, spicy chili garlic, and sweet sauce",
                MenuItemPrice = 15.95},

                //Tempura Rolls
                new MenuItem{SubcategoryID=6, MenuItemName="Wonton", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Cream cheese, avocado, scallions, choice of shrimp or surimi crab",
                MenuItemPrice = 7.49},
                new MenuItem{SubcategoryID=6, MenuItemName="Wolverine", Piece=6, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy tuna, snow crab, spicy cream cheese, avocado, cucumber, top with sweet garlic and spicy sauces",
                MenuItemPrice = 8.95},
                new MenuItem{SubcategoryID=6, MenuItemName="Vegas", Piece=10, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, cream cheese, avocado, scallions, jalapeño, top with dynamite and sweet sauces",
                MenuItemPrice = 7.25},
                new MenuItem{SubcategoryID=6, MenuItemName="Eskimo	", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Smoked salmon, snow crab, cream cheese, avocado, cucumber, topped with sweet wasabi sauce",
                MenuItemPrice = 8.95},
                new MenuItem{SubcategoryID=6, MenuItemName="Cali Crunch", Piece=10, Cooked=true, Vegetarian=false,
                MenuItemDescription="California roll with sweet sauce",
                MenuItemPrice = 5.25},

                // Grills 
                new MenuItem{SubcategoryID=7, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rice",
                MenuItemPrice = 9.95},
                new MenuItem{SubcategoryID=7, MenuItemName="Sirloin Steak", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rice",
                MenuItemPrice = 10.95},
                new MenuItem{SubcategoryID=7, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rice",
                MenuItemPrice = 10.95},

                new MenuItem{SubcategoryID=8, MenuItemName="Tofu", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 8.95},
                new MenuItem{SubcategoryID=8, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 9.95},
                new MenuItem{SubcategoryID=8, MenuItemName="Sirloin Steak", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 10.95},
                new MenuItem{SubcategoryID=8, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 10.95},

                new MenuItem{SubcategoryID=9, MenuItemName="Tofu Japansese", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 8.95},
                new MenuItem{SubcategoryID=9, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 9.95},
                new MenuItem{SubcategoryID=9, MenuItemName="Sirloin Steak", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 10.95},
                new MenuItem{SubcategoryID=9, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 10.95},
            };
            menuItems.ForEach(s => context.MenuItems.Add(s));
            context.SaveChanges();

            var menuPictures = new List<MenuPicture>
            {
                new MenuPicture{MenuItemID=1, PicturePathname="~/Photos/Normal/SushiRoll1.jpg", 
                                ThumbnailPathname="~/Photos/Thumbnail/pictur1.jpg"},
                new MenuPicture{MenuItemID=2, PicturePathname="~/Photos/Normal/SushiRoll2.jpg",
                                ThumbnailPathname="~/Photos/Thumbnail/pictur1.jpg"},
                new MenuPicture{MenuItemID=3, PicturePathname="~/Photos/Normal/SushiRoll3.jpg",
                                ThumbnailPathname="~/Photos/Thumbnail/pictur3.jpg"},
            };
            menuPictures.ForEach(s => context.MenuPictures.Add(s));
            context.SaveChanges();

            var replies = new List<Reply>
            {
                new Reply{CommentID=1, UserID=4, CommentDate=DateTime.Parse("2015-04-15"), CommentContents="OWWWAHAKDJKSLDHLK"},
                new Reply{CommentID=2, UserID=5, CommentDate=DateTime.Parse("2015-03-15"), CommentContents="Tis da bomb diggity"},
                new Reply{CommentID=3, UserID=6, CommentDate=DateTime.Parse("2015-01-12"), CommentContents="Burrito Sushi say whaaa?"}
            };
            replies.ForEach(s => context.Replies.Add(s));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment{MenuItemID=1, UserID=1, CommentDate=DateTime.Parse("2014-12-28"), CommentContents="OMGGGGG"},
                new Comment{MenuItemID=1, UserID=2, CommentDate=DateTime.Parse("2015-04-07"), CommentContents="This changed my life forever"},
                new Comment{MenuItemID=1, UserID=3, CommentDate=DateTime.Parse("2015-02-21"), CommentContents="Defintely coming back here for more!"},
            };
            comments.ForEach(s => context.Comments.Add(s));
            context.SaveChanges();

        }
    }
}
