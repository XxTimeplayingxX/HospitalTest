using System.Reflection.PortableExecutable;

namespace Hospital.MODELS
{
    public class DetalleReceta
    {
        public int Id_DetalleReceta { get; set; }
        public int Receta_id { get; set; }
        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public string Duracion { get; set; }
        public string Instrucciones { get; set; }
        public Receta Receta { get; set; }
    }
}
