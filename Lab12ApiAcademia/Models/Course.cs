namespace Lab12ApiAcademia.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int DuracionHoras { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
        public bool isActive { get; set; }
    }
}
