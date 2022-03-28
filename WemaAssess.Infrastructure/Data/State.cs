using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WemaAssess.Infrastructure.Data
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Capital { get; set; }

        public virtual ICollection<Lga> Lga { get; set; }
    }
}
