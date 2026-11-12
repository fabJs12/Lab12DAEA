namespace Lab12ApiAcademia.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int EnrollmentId { get; set; }
        public Enrollment Enrollment { get; set; } = null!;
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoPago { get; set; }
    }
}
