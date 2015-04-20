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
                new MenuCategory{CategoryName="Sushi Burrito", CategoryDescription="Sushi combined into a burrito rice wrap"},
                new MenuCategory{CategoryName="Grills", CategoryDescription="Asian Grills are your traditional cooked foods like teryaki chicken"},
                new MenuCategory{CategoryName="Sushi Rolls", CategoryDescription="Contains your classic california roll to special rolls"},
            };
            menuCategories.ForEach(s => context.MenuCategories.Add(s));
            context.SaveChanges();

            var menuItems = new List<MenuItem>
            {
                new MenuItem{CategoryID=1, CategoryName="Sushi Burrito", MenuItemName="Califronia", 
                MenuItemDescription="Surimi crab, avocado, cream cheese, cucumber, tempura flakes, carrot, seaweed salad, sweet soy reduction",
                MenuItemPrice= 8.95},
                new MenuItem{CategoryID=1, CategoryName="Sushi Burrito", MenuItemName="Neptune", 
                MenuItemDescription="Tempura calamri, spicy cream cheese, avacado, cucumber, tempura flakes, shredded carrot, seaweed salad, spicy sauce, sweet soy reduction",
                MenuItemPrice= 10.95},
                new MenuItem{CategoryID=1, CategoryName="Sushi Burrito", MenuItemName="Spicy Tuna", 
                MenuItemDescription="Avacado, cucumber, spicey tuna, tempura flakes, carrot, seaweed salad, spicy sauce, sweet soy reduction",
                MenuItemPrice= 12.95}
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
