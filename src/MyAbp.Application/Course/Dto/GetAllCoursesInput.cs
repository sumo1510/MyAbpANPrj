using Abp.Application.Services.Dto;
using MyAbp.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbp.Course.Dto
{
    public class GetAllCoursesInput : PagedResultRequestDto
    {
        public StatusCode? Status { get; set; }
    }
}
