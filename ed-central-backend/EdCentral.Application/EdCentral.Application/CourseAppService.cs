using EdCentral.Application.Interfaces;
using EdCentral.Domain;
using EdCentral.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace EdCentral.Application
{
    public class CourseAppService : ICourseAppService
    {
        public async Task Create(Course course)
        {
            try
            {
                using (var db = new EdCentralContext())
                {
                    await db.Courses.AddAsync(course);

                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(Course course)
        {
            try
            {
                using (var db = new EdCentralContext())
                {
                    db.Courses.Remove(course);

                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(Course course)
        {
            try
            {
                using (var db = new EdCentralContext())
                {
                    db.Courses.Update(course);

                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            try
            {
                using (var db = new EdCentralContext())
                {
                    return await db.Courses.OrderBy(x => x.CompanyId).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
