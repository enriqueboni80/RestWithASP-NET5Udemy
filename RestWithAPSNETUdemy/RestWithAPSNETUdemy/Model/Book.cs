using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAPSNETUdemy.Model
{
    [Table("book")]
    public class Book
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("autor")]
        public string Autor { get; set; }
    }
}
