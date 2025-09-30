using System;

namespace POO_Figuras
{
    abstract class FiguraGeometrica
    {
        public abstract string Description();
        public abstract double Area();
    }

    class Cuadrilatero : FiguraGeometrica
    {
        private double baseCuadrilatero;
        private double altura;

        public Cuadrilatero(double baseCuadrilatero, double altura)
        {
            this.baseCuadrilatero = baseCuadrilatero;
            this.altura = altura;
        }
        public override string Description()
        {
            return (baseCuadrilatero == altura) ? "Figura geométrica: Cuadrado" : "Figura geométrica: Rectángulo";
        }
        public override double Area()
        {
            return baseCuadrilatero * altura;
        }
    }

    class Triangulo : FiguraGeometrica
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }
        public override string Description()
        {
            return "Figura geométrica: Triángulo";
        }
        public override double Area()
        {
            return (baseTriangulo * altura) / 2;
        }
    }

    class Circulo : FiguraGeometrica
    {
        private double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override string Description()
        {
            return "Figura geométrica: Círculo";
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    internal class Program
    {
        static double PedirNumero(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }
                Console.WriteLine("Error: Ingrese un número válido mayor que 0.");
            }
        }

        static string ElegirUnidad()
        {
            string[] unidades = { "cm", "m", "in" };
            Console.WriteLine("\nSeleccione la unidad de medida:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }

            while (true)
            {
                Console.Write("Opción: ");
                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= unidades.Length)
                {
                    return unidades[opcion - 1];
                }
                Console.WriteLine("Error: Opción no válida.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSeleccione una figura geométrica");
                Console.WriteLine("1. Cuadrilátero");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Círculo");
                Console.WriteLine("4. Salir");

                Console.Write("Ingrese una opción: ");
                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Error: Ingrese un número entero.");
                    continue;
                }

                if (opcion == 4)
                {
                    Console.WriteLine("Gracias por usar el programa.");
                    break;
                }

                string unidad = ElegirUnidad();
                FiguraGeometrica figura = null;

                switch (opcion)
                {
                    case 1:
                        double base1 = PedirNumero($"Ingrese la base ({unidad}): ");
                        double altura1 = PedirNumero($"Ingrese la altura ({unidad}): ");
                        figura = new Cuadrilatero(base1, altura1);
                        break;

                    case 2:
                        double base2 = PedirNumero($"Ingrese la base ({unidad}): ");
                        double altura2 = PedirNumero($"Ingrese la altura ({unidad}): ");
                        figura = new Triangulo(base2, altura2);
                        break;

                    case 3:
                        double radio = PedirNumero($"Ingrese el radio ({unidad}): ");
                        figura = new Circulo(radio);
                        break;

                    default:
                        Console.WriteLine("Error: Opción no válida.");
                        continue;
                }

                Console.WriteLine($"\nHas seleccionado: {figura.Description()}");
                Console.WriteLine($"El área es: {figura.Area():F2} {unidad}²");
            }
        }
    }
}
