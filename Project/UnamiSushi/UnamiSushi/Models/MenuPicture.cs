using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnamiSushi.Models
{
    public class MenuPicture
    {
        public int PictureID { get; set; } //Primary key 

        public int PictureItem { get; set; } //Foreign key to menu item

        //public string PictureName { get; set; } //Name of picture
        //public string PictureDescription { get; set; } //Short description of picture

        public string PicturePathname { get; set; } //Contains pathname to a high resolution picture of the menu item
        public string ThumbnailPathname { get; set; } //Contains a pathname to a lower resolution thumbnail of the menu item picture
    }
}