using System.Collections.Generic;

namespace EdCentral.Domain
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
