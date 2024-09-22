namespace ProjetoGeometria.Models
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Nome = "Círculo";
            Raio = raio;
        }

        public override double Area
        {
            get { return Math.PI * Raio * Raio; }
        }
    }
}
