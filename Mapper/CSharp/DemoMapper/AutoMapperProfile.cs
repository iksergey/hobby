using AutoMapper;
using Model;

namespace AppConfig
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<Worker, WorkerDto>();
      CreateMap<Worker, Worker>();
    }
  }
}