using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WemaAssess.Data.Dtos;

namespace WemaAssess.Data.Services.Interfaces
{
    public interface ILgaService
    {
        Task<List<LgaDto>> GetByStateId(int id);
    }
}
