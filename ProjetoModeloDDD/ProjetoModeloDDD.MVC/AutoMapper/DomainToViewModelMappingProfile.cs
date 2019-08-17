using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }        
    }

    // How it was done in 4.x - as of 5.0 this is obsolete:
    // public class OrganizationProfile : Profile
    // {
    //     protected override void Configure()
    //     {
    //         CreateMap<Foo, FooDto>();
    //     }
    // }
}