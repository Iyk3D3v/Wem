using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WemaAssess.Infrastructure.Repository;
using WemaAssess.Data.Dtos;
using System.Linq;
using WemaAssess.Data.Services.Interfaces;

namespace WemaAssess.Data.Services.Implementation
{
    public class LgaService : ILgaService
    {
        private IUnitOfWork _unit;
        private readonly IMapper _mapper;
        public LgaService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        //this service is to handle ( lga must be mapped to state id) 
        public async Task<List<LgaDto>> GetByStateId(int id)
        {
            try
            {
                var res = await _unit.Lga.GetByAsync(p=>p.StateId == id);

                var model = _mapper.Map<List<LgaDto>>(res.ToList());
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
