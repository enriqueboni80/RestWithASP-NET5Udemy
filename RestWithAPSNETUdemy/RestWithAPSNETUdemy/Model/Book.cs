using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using RestWithAPSNETUdemy.Model.Base;

namespace RestWithAPSNETUdemy.Model
{
    [Table("book")]
    public class Book : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("autor")]
        public string Autor { get; set; }
    }
}
