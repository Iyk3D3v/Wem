using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WemaAssess.Data.Dtos;
using WemaAssess.Data.Services.Interfaces;
using WemaAssess.Infrastructure.Repository;
using System.Linq;

namespace WemaAssess.Data.Services.Implementation
{
    public class StateService : IStateService
    {
        private IUnitOfWork _unit;
        private readonly IMapper _mapper;
        public StateService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }
        public async Task<List<StateDto>> GetAll()
        {
            try
            {
                var res = await _unit.State.GetAllAsync();

                var model = _mapper.Map<List<StateDto>>(res.ToList());
                return model;
            }
            catch(Exception ex )
            {
                throw ex;
            }
        }
    }
}
