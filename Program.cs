using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4J_LSC_CarolinaLondoño_04
{
    abstract class figurageometrica{
        public abstract string Description();
        public abstract double area();
    }

    class Cuadrilatero : figurageometrica {
        private double basecuadrilatero;
        private double altura;

        public Cuadrilatero(double basecuadrilatero, double altura){
            this.basecuadrilatero = basecuadrilatero;
            this.altura = altura;
        }
        public override string Description()
        {   
            if (basecuadrilatero == altura)
            {
                return "Figura geométrica cuadrado";
            }
            else
                return "Figura geométrica cuadrilatero";
            //throw new NotImplementedException();
        }
        public override double area() {
            return basecuadrilatero*altura; 
        }
    }

    class triangulo : figurageometrica
    {
        private double baseTriangulo;
        private double altura;

        public triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }
        public override string Description()
        {
            return "Figura geométrica triangulo";
            //throw new NotImplementedException();
        }
        public override double area()
        {
            return (baseTriangulo * altura)/2;
        }
    }
    class circulo : figurageometrica {
        private double radio;
        public circulo(double radio) { 
            this.radio = radio;
        }

        public override string Description() {
            return "Figura geométrica círculo";
        }
        //Override es la palabra clave para la relación con la clase abstract(principal)
        public override double area(){
            //return(radio * radio) * Math.PI;
            return Math.PI * Math.Pow(radio, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una opción: ");
            int opcion = int.Parse(Console.ReadLine()); 

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(" === Información del cuadrilatero ==== ");
                    Console.WriteLine("Ingresa la base: ");
                    double base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura: ");
                    double altura1 = double.Parse(Console.ReadLine());

                    Cuadrilatero cuadrilatero = new Cuadrilatero(base1, altura1);

                    break;
            }
                
            
        }
    }
}
