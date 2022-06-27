using Abp.Application.Services.Dto;

namespace HospitalBasico.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

