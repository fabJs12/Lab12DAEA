namespace Lab12ApiAcademia.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public DateTime FechaMatricula { get; set; }
        public string Estado { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
