namespace ProjetoGeometria.Models
{
    public class Triangulo : Forma
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            Nome = "Triângulo";
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public override double Area
        {
            get
            {
                double s = (LadoA + LadoB + LadoC) / 2;
                return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
            }
        }
    }
}
