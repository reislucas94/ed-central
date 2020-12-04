using System;

namespace EdCentral.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public CourseStatus Status { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public Company Company { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
