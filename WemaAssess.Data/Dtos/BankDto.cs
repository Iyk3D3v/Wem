using System;
using System.Collections.Generic;
using System.Text;

namespace WemaAssess.Data.Dtos
{
    public class BankDto
    {
        public string BankName { get; set; }
        public string BankCode { get; set; }
    }


    public class BankWrapperDto
    {
        public List<BankDto> Result { get; set; }
    }
}
