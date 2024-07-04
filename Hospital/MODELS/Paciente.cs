namespace Hospital.MODELS
{
    public class Paciente
    {
        public int Id { get; set; }
        public string HistorialMedico { get; set; }
        public int Persona_id { get; set; }
        public Persona Persona { get; set; }
    }
}
