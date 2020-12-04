using EdCentral.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdCentral.Application.Interfaces
{
    public interface ICourseAppService
    {
        Task Create(Course course);
        Task Update(Course course);
        Task<IEnumerable<Course>> GetAll();
        Task Delete(Course course);
    }
}