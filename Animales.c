using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    abstract class Animal
    {
        public abstract string Descripcion();
        public abstract double Caracteristicas();
    }

    class Mamifero : Animal
    {
        public override string Descripcion()
        {
            return "Animal de sangre caliente que amamanta a sus crías";
        }

        public override double Caracteristicas()
        {
            return 2 + 4; 
        }
    }

    class Anfibio : Animal
    {
        public override string Descripcion()
        {
            return "Animal capaz de vivir tanto en el agua como en la tierra";
        }

        public override double Caracteristicas()
        {
            return 3 * 5;
        }
    }

    class Reptil : Animal
    {
        public override string Descripcion()
        {
            return "Animal de sangre fría que posee escamas";
        }

        public override double Caracteristicas()
        {
            return Math.Pow(2, 4) / (23.0 / 5); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menú");
            Console.WriteLine("1. Mamífero");
            Console.WriteLine("2. Anfibio");
            Console.WriteLine("3. Reptil");

            Console.Write("Seleccione una opción: ");
            int op = int.Parse(Console.ReadLine());

            Animal animal;

            if (op == 1)
            {
                animal = new Mamifero();
            }
            else if (op == 2)
            {
                animal = new Anfibio();
            }
            else if (op == 3)
            {
                animal = new Reptil();
            }
            else
            {
                Console.WriteLine("Opción no válida");
                return;
            }

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine("Descripción: " + animal.Descripcion());
            Console.WriteLine("Características (operación aritmética): " + animal.Caracteristicas());
        }
    }
}
