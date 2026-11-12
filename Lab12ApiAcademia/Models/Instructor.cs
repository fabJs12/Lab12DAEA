namespace Lab12ApiAcademia.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Especialidad { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
    }
}
