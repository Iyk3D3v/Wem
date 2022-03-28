using System;
using System.Collections.Generic;
using System.Text;

namespace WemaAssess.Data.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string Lga { get; set; }
        public string Password { get; set; }
    }
}
