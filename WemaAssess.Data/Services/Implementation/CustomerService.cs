using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WemaAssess.Data.Dtos;
using WemaAssess.Data.Services.Interfaces;
using WemaAssess.Infrastructure.Data;
using WemaAssess.Infrastructure.Repository;
using System.Linq;

namespace WemaAssess.Data.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;
        public CustomerService(IMapper mapper, IUnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;
        }
        //add two extra methods'for
        // sending otp
        // receievong otp

        //verifying token
        public async Task<bool> Add(CustomerDto req)
        {
            try
            {
                var model = _mapper.Map<Customer>(req);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<List<CustomerDto>> GetAll()
        {
            try
            {
                var res = await _unit.Customer.GetAllAsync();

                var model = _mapper.Map<List<CustomerDto>>(res.ToList());
                return new List<CustomerDto>();
            }
            catch(Exception ex)
            {
                return new List<CustomerDto>();
            }
        }
    }
}
