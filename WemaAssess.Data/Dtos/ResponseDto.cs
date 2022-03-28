using System;
using System.Collections.Generic;
using System.Text;

namespace WemaAssess.Data.Dtos
{
    public class ResponseDto
    {
        public object Data { get; set; }

        public string Message { get; set; }

        public bool Status { get; set; }
    }
}
