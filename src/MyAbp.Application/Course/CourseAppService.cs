using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using MyAbp.Course.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAbp.Course
{
    public class CourseAppService : AsyncCrudAppService<Entitys.Course, CourseDto, int, GetAllCoursesInput,
                             CreateUpdateCourseDto, CreateUpdateCourseDto>, ICourseAppService

    {
        public CourseAppService(IRepository<Entitys.Course, int> repository)
            : base(repository)
        {
            
        }

        public override Task<CourseDto> CreateAsync(CreateUpdateCourseDto input)
        {
            var sin = input;
            return base.CreateAsync(input);
        }
        public override async Task<PagedResultDto<CourseDto>> GetAllAsync(GetAllCoursesInput input)
        {
            var query =base.CreateFilteredQuery(input).WhereIf(input.Status.HasValue, t => t.Status == input.Status.Value);
            //var query = base.CreateFilteredQuery(input).WhereIf(input.Status.HasValue, t => t.Status == 1);
            var coursecount = query.Count();
            var courselist = query.ToList();
            //PagedResultDto < CourseDto > result=new PagedResultDto<CourseDto>()
            //{
            //    TotalCount = coursecount,
            //    Items =ObjectMapper.Map<List<CourseDto>>(courselist)
            //};
            return new PagedResultDto<CourseDto>()
            {
                TotalCount = coursecount,
                Items = ObjectMapper.Map<List<CourseDto>>(courselist)
            };
        }
        
        //public Task<PagedResultDto<CourseDto>> GetAllAsync(PagedResultRequestDto input)
        //{
        //    throw new System.NotImplementedException();
        //}
        //public override async Task<PagedResultDto<CourseDto>> 
        //public override async Task<PagedResultDto<CourseDto>> GetAllAsync(GetAllCoursesInput input)
        //{
        //    var query = base.CreateFilteredQuery(input).WhereIf(input.Status.HasValue, t => t.Status == input.Status.Value);
        //    var coursecount = query.Count();
        //    var courselist = query.ToList();
        //    return new PagedResultDto<CourseDto>()
        //    {
        //        TotalCount = coursecount,
        //        Items = ObjectMapper.Map<List<CourseDto>>(courselist)
        //    };
        //}
    }
}