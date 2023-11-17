namespace AgendaDeAulas.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public int ProfessorId { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; } 
    }
}
