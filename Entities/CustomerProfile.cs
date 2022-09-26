using AutoMapper;

namespace Geekosphere_backend.Entities
{
    public class CustomerProfile : Profile
    {

        public CustomerProfile()
        {
            CreateMap<CustomerRegistration, Customer>();

        }
    }
}
