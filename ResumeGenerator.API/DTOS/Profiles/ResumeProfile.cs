using AutoMapper;
using ResumeGenerator.Core;

namespace ResumeGenerator.API;

public class ResumeProfile : Profile
{
    public ResumeProfile()
    {
        CreateMap<Address, AddressDTO>();
        CreateMap<AddressDTO, Address>()
            .ForMember(a => a.Id, opt => opt.Ignore());

        CreateMap<Certificate, CertificateDTO>();
        CreateMap<CertificateDTO, Certificate>()
            .ForMember(c => c.Id, opt => opt.Ignore());

        CreateMap<Education, EducationDTO>();
        CreateMap<EducationDTO, Education>()
            .ForMember(e => e.Id, opt => opt.Ignore());

        CreateMap<Language, LanguageDTO>()
            .ForMember(l => l.Level, otp => otp.MapFrom(l => l.Level.ToString()));
        CreateMap<LanguageDTO, Language>()
            .ForMember(l => l.Id, otp => otp.Ignore())
            .ForMember(l => l.Level, otp => otp.MapFrom(l => Enum.GetName(typeof(Levels), l.Level)));

        CreateMap<Person, PersonDTO>();
        CreateMap<PersonDTO, Person>()
            .ForMember(p => p.Id, opt => opt.Ignore());

        CreateMap<Skill, SkillDTO>()
            .ForMember(s => s.Level, otp => otp.MapFrom(s => s.Level.ToString()));
        CreateMap<SkillDTO, Skill>()
            .ForMember(s => s.Id, opt => opt.Ignore())
            .ForMember(s => s.Level, otp => otp.MapFrom(s => Enum.GetName(typeof(Levels), s.Level)));

        CreateMap<Template, TemplateDTO>()
          .ForMember(t => t.Theme, otp => otp.MapFrom(t => t.Theme.ToString()))
          .ForMember(t => t.FontSize, otp => otp.MapFrom(t => t.FontSize.ToString()))
          .ForMember(t => t.Font, otp => otp.MapFrom(t => t.Font.ToString()));
        CreateMap<TemplateDTO, Template>()
            .ForMember(t => t.Id, opt => opt.Ignore())
            .ForMember(t => t.Theme, otp => otp.MapFrom(t => Enum.GetName(typeof(ResumeTheme), t.Theme)))
            .ForMember(t => t.FontSize, otp => otp.MapFrom(t => Enum.GetName(typeof(FontSizes), t.FontSize)))
            .ForMember(t => t.Font, otp => otp.MapFrom(t => Enum.GetName(typeof(FontFamilies), t.Font)));

        CreateMap<WorkplaceDTO, Workplace>();
        CreateMap<WorkplaceDTO, Workplace>()
            .ForMember(w => w.Id, otp => otp.Ignore());
    }
}
