using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WemaAssess.Infrastructure.Data
{
    public class Lga
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        [ForeignKey("State")]
        public int StateId { get; set; }

        public virtual State State { get; set; }
    }
}
