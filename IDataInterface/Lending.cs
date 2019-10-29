﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDataInterface
{
    public interface Lending
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LendingID { get; set; }
        public int LendingNumber { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int TimeSlotID { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}