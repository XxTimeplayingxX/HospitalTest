namespace Hospital.MODELS
{
    public class Receta
    {
        public int Id_Receta { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Medico_id { get; set; }
        public int Paciente_id { get; set; }
        public string Comentarios { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }
}
