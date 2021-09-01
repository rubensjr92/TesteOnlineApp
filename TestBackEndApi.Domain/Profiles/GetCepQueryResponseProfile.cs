using AutoMapper;
using TestBackEndApi.Domain.Queries.Cep.Get;
using TestBackEndApi.Infrastructure.Services.Contract;

namespace TestBackEndApi.Domain.Profiles
{
    public class GetCepQueryResponseProfile : Profile
    {
        public GetCepQueryResponseProfile()
        {
            CreateMap<CepResponse, GetCepQueryResponse>().ForMember(d => d.Localidade, d => d.MapFrom(x => string.Format("{0} - {1}", x.Localidade, x.Uf))); ;
            CreateMap<MensagemResponse, MensagemQueryResponse>().ReverseMap();
            CreateMap<GetCepQuery, CepRequest>().ReverseMap();
            CreateMap<string, CepResponse>();
            //CreateMap<GetCepQueryResponse, MensagemResponse>().ReverseMap();
        }
    }
}
