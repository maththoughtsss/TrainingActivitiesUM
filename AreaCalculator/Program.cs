namespace AreaCalculator
{
    class Program
    {
        //Por convención las variables y funciones del programa están indicadas en inglés, sin embargo, la interfaz con es usuario retorna los mensajes en idioma español.
        public static void Main(string[] args)
        {
            //Bienvenida y Menú de Selección
            Selection();
        }
        public static void Selection()
        {
            //Declaración de Variables de Selección
            string? strShape;
            int numShape;

            //Enunciado de Selección
            Console.WriteLine("Bienvenido a la aplicación para Cálculo de Áreas \n");
            Console.WriteLine("Por favor, ingrese el tipo de figura a calcular: \n");
            Console.WriteLine(" 1.- Circunferencia \n 2.- Rectángulo \n 3.- Triángulo");

            //Conversión de String a Int para Selección
            strShape = Console.ReadLine();
            int.TryParse(strShape, out numShape);

            //Switch de Selección (Elección de Función a utilizar)
            switch(numShape)
            {   
                //case 1 - Corre Función para calcular el área de una circunferencia
                case 1:
                {
                    circumferenceArea();
                    break;
                }
                //case 2 - Corre Función para calcular el área de un rectángulo
                case 2:
                {
                    rectangleArea();
                    break;
                }
                //case 3 - Corre Función para calcular el área de un triángulo
                case 3:
                {
                    triangleArea();
                    break;
                }
            }
        }
        //Función de Retorno o Salida
        public static void returnOrClose()
        {
            //Consulta para continuar o salir del programa
            Console.WriteLine("Desea volver a calcular nuevamente (Y/N)");
            string? numChoice = Console.ReadLine();            
            if(numChoice == "Y") //Retorna a la función para un nuevo cálculo
            {
                circumferenceArea();
            }
            if(numChoice == "N") //Salida del programa
            {
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
            }
            else //Retorna de manera recursiva la función en caso de presionar cualquier otra tecla...
            {
                returnOrClose();
            }            
        }
        public static void circumferenceArea()
        //Función para calcular el área de una circunferencia
        {
            //Declaración de Variables
            string? strRadius;
            double NumRadius, circArea, pi;
            pi = 3.14;
            //Título
            Console.WriteLine("CALCULAR EL ÁREA DE UNA CIRCUNFERENCIA \n");
            //Input
            Console.WriteLine("Ingresa el radio de la circunferencia: ");            
            strRadius = Console.ReadLine();
            //Función de Cálculo
            double.TryParse(strRadius, out NumRadius);
            circArea= NumRadius * NumRadius * pi;
            //Output
            Console.WriteLine($"Total Area: {circArea} u2");
            //Retornar o Salir
            returnOrClose();
        }
        public static void rectangleArea()
        //Función para calcular el área de un rectángulo
        {
            //Delcaración de Variables
            string? strHeight, strWidth;
            double height, width, rectArea;
            //Título
            Console.WriteLine("CALCULAR EL ÁREA DE UN RECTÁNGULO \n");
            //Inputs
            //Altura
            Console.WriteLine("Ingresa la altura del rectángulo: ");            
            strHeight = Console.ReadLine();
            //Ancho
            Console.WriteLine("Ingresa el ancho del rectángulo: ");            
            strWidth = Console.ReadLine();
            //Conversión de Variables y Función de Cálculo
            double.TryParse(strHeight, out height);
            double.TryParse(strWidth, out width);
            rectArea = height * width;
            //Output
            Console.WriteLine($"Área total del Rectángulo: {rectArea} u2");
            //Retornar o Salir
            returnOrClose();
        }
        public static void triangleArea()
        //Función para calcular el área de un triángulo
        {
            //Declaración de Variables
            string? strHeight, strWidth;
            double height, width, triArea;
            //Título
            Console.WriteLine("CALCULAR EL ÁREA DE UN TRIÁNGULO \n");
            //Inputs
            //Altura
            Console.WriteLine("Ingresa la altura del triángulo: ");            
            strHeight = Console.ReadLine();
            //Base
            Console.WriteLine("Ingresa el ancho del triángulo: ");            
            strWidth = Console.ReadLine();
            //Conversión de Variable y Función de Cálculo
            double.TryParse(strHeight, out height);
            double.TryParse(strWidth, out width);
            triArea = height * width / 2;
            //Output
            Console.WriteLine($"Área total del Triángulo: {triArea} u2");
            //Retornar o Salir
            returnOrClose();
        }
    }
}