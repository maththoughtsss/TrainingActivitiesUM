namespace ConEjercicios_AreaTotal
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaración de Variables
            string? strHeight,strRadius;
            double height, radius, cylinderArea, pi, radiusSquared;
            pi = 3.14;
            
            //Título
            Console.WriteLine("Cálculo de Área de un Cilindro Recto \n");
            //Input
            Console.WriteLine("Ingrese la altura del cilindro: ");            
            strHeight = Console.ReadLine();
            Console.WriteLine("Ingrese el radio de cilindro: ");            
            strRadius = Console.ReadLine();
            //Función de Cálculo
            double.TryParse(strHeight, out height);
            double.TryParse(strRadius, out radius);

            radiusSquared = radius * radius;
            
            cylinderArea= 2 * pi * radius * height + 2 * pi * radiusSquared;
            //Output
            Console.WriteLine("+++++++ +++++++ +++++++ +++++++ +++++++ +++++++");
            Console.WriteLine($"\t Área total del cilindro: {cylinderArea} u2");
            Console.WriteLine("+++++++ +++++++ +++++++ +++++++ +++++++ +++++++");
            //Salida
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}