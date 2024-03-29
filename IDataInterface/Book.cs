﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDataInterface
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        public int BookNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PurchaseYear { get; set; }
        public int PurchaseCost { get; set; }
        public int Condition { get; set; }
        public string ISBN { get; set; }
        public int ShelfID { get; set; }
        public Shelf Shelf { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Return> Return { get; set; }
        public int ScraplistID { get; set; }
        public Scraplist Scraplist { get; set; }
        public bool Deleted { get; set; }
    }
}