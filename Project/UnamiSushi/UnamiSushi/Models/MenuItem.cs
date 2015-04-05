﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnamiSushi.Models
{
    public class MenuItem
    {
        public int MenuItemID { get; set; } //Primary Key

        public string MenuItemCategory { get; set; } //Foreign key to category menu items belongs to

        public string MenuItemName { get; set; } //Short name of the particular dish

        public string MenuItemDescription { get; set; } //Contains a description of the menu item

        public double MenuItemPrice { get; set; } //Lists the current price of the menu item

        //public string PicturePathname { get; set; } //obsolete, linked to separate menu picture item with picture and thumbnail
        //public string ThumbnailPathname { get; set; } 


        public virtual ICollection<MenuPicture> ItemGallery { get; set; }


    }
}