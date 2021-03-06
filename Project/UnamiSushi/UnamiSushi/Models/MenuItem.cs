﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnamiSushi.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemID { get; set; } //Primary Key

        public int CategoryID { get; set; } //foreign key
        
        public string CategoryName { get; set; }

        public string MenuItemName { get; set; } //Short name of the particular dish

        public string MenuItemDescription { get; set; } //Contains a description of the menu item

        public double MenuItemPrice { get; set; } //Lists the current price of the menu item

        //public string PicturePathname { get; set; } //obsolete, linked to separate menu picture item with picture and thumbnail
        //public string ThumbnailPathname { get; set; } 


        public virtual ICollection<MenuPicture> MenuPictures { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }


    }
}
