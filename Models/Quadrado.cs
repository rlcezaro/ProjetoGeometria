namespace ProjetoGeometria.Models
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Nome = "Quadrado";
            Lado = lado;
        }

        public override double Area
        {
            get { return Lado * Lado; }
        }
    }
}
