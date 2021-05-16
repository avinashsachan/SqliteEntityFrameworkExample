﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleCSharp
{
    [Table("Table1")]
   public class Table1
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}
