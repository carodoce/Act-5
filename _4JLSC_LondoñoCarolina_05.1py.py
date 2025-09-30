import math

class FiguraGeometrica:
    def descripcion(self):
        return "Soy una figura geométrica"
    
    def area(self):
        raise NotImplementedError("Este método debe ser implementado en las subclases")

class Cuadrilatero(FiguraGeometrica):
    def __init__(self, base, altura):
        self.base = base
        self.altura = altura

    def descripcion(self):
        return "Cuadrilátero"
    
    def area(self):
        return self.base * self.altura

class Triangulo(FiguraGeometrica):
    def __init__(self, base, altura):
        self.base = base
        self.altura = altura 

    def descripcion(self):
        return "Triángulo"
    
    def area(self):
        return (self.base * self.altura) / 2

class Circulo(FiguraGeometrica):
    def __init__(self, radio):
        self.radio = radio

    def descripcion(self):
        return "Círculo"
    
    def area(self):
        return math.pi * (self.radio ** 2)

def pedir_float(mensaje):
    """Función auxiliar para pedir números con validación."""
    while True:
        try:
            valor = float(input(mensaje))
            if valor <= 0:
                print("Error: ingrese un número mayor a 0.")
            else:
                return valor
        except ValueError:
            print("Error: ingrese un número válido.")

def elegir_unidad():
    """Permite elegir la unidad de medida."""
    unidades = ["cm", "m", "in"]
    print("\nSeleccione la unidad de medida:")
    for i, u in enumerate(unidades, 1):
        print(f"{i}. {u}")
    while True:
        try:
            opcion = int(input("Opción: "))
            if 1 <= opcion <= len(unidades):
                return unidades[opcion - 1]
            else:
                print("Error: opción no válida.")
        except ValueError:
            print("Error: ingrese un número válido.")

def main():
    while True:
        print("\n Selecciona una figura geométrica")
        print("1. Cuadrilátero")
        print("2. Triángulo")
        print("3. Círculo")
        print("4. Salir")

        try:
            opcion = int(input("Ingrese una opción: "))
        except ValueError:
            print("Error: ingrese un número entero.")
            continue
        
        if opcion == 4:
            print("Gracias por usar el programa.")
            break

        unidad = elegir_unidad()

        if opcion == 1:
            base = pedir_float(f"Ingrese la base ({unidad}): ")
            altura = pedir_float(f"Ingrese la altura ({unidad}): ")
            figura = Cuadrilatero(base, altura)

        elif opcion == 2:
            base = pedir_float(f"Ingrese la base ({unidad}): ")
            altura = pedir_float(f"Ingrese la altura ({unidad}): ")
            figura = Triangulo(base, altura)

        elif opcion == 3:
            radio = pedir_float(f"Ingrese el radio ({unidad}): ")
            figura = Circulo(radio)

        else:
            print("Opción no válida.")
            continue

        print(f"\nHas seleccionado: {figura.descripcion()}")
        print(f"➡️ El área es: {figura.area():.2f} {unidad}²")

if __name__ == "__main__":
    main()

