namespace Hospital.MODELS
{
    public class Medico
    {
        public int ID { get; set; }
        public int Persona_Id { get; set; }
        public string Especialidad { get; set; }
        public string Cargo { get; set; }
        public Persona Persona { get; set; }
    }
}
