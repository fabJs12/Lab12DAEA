namespace Lab12ApiAcademia.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool isActive { get; set; }
    }
}
