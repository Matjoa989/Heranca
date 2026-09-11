namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();
            R.Altura = 10;
            R.Largura = 15;
            Console.WriteLine(R.CalcularArea());

            Circulo C = new Circulo();
            C.Raio = 5;
            Console.WriteLine(C.CalcularArea());
        }
    }
}
