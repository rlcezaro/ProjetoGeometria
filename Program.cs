using ProjetoGeometria.Models;

class Program
{
    static void Main(string[] args)
    {
        Forma quadrado = new Quadrado(4);
        Console.WriteLine($"{quadrado.Nome} - Área: {quadrado.Area}");

        Forma circulo = new Circulo(3);
        Console.WriteLine($"{circulo.Nome} - Área: {circulo.Area}");

        Forma triangulo = new Triangulo(3, 4, 5);
        Console.WriteLine($"{triangulo.Nome} - Área: {triangulo.Area}");
    }
}
