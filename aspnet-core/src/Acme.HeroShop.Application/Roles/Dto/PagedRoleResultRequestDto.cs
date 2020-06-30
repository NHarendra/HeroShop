using Abp.Application.Services.Dto;

namespace Acme.HeroShop.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

