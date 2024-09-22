namespace ProjetoGeometria.Models
{
    public abstract class Forma
    {
        public string? Nome { get; set; }
        public abstract double Area { get; }
    }
}