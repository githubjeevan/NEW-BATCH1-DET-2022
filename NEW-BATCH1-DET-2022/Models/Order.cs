﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NEW_BATCH1_DET_2022.Models.Customer;

namespace NEW_BATCH1_DET_2022.Models
{
    
      [Table("MyOrder")]
        public class Order
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int Order_ID { get; set; }

            public DateTime OrderDate { get; set; }

            [Column("OrderAmt")]
            public int Amount { get; set; }

            public Customer? cust { get; set; } //navigation prop
        }
    
}
