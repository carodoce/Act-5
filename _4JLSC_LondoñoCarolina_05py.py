import math
class figuraGeometrica:
    def __init__(self):
        pass
    def descripcion(self):
        return "Soy una figura geometrica"
    def area(self):
        return 0

class cuadrilatero(figuraGeometrica):
    def __init__(self, base, altura):
        self.base = base
        self.altura = altura
    def descripcion (self):
        return "cuadrilatero"
    def area(self):
        return self.base * self.altura

class triangulo(figuraGeometrica):
    def __init__(self, base, altura):
        self.base = base
        self.altura = altura 
    def descripcion (self):
        return "Triangulo"
    def area(self):
        return (self.base * self.altura)/2

class circulo(figuraGeometrica):
    def __init__(self, radio):
        self.radio = radio
    def descripcion(self):
        return "Circulo"
    def area (self):
        return math.pi *(self.radio **2)

def main ():
    print("Selecciona una figura geométrica")
    print("1. Cuadrilatero")
    print("2. Triangulo")
    print("3. Circulo")
    try:
        opcion=int(input("Ingrese un valor del 1 al 3. "))
    except ValueError:
        print("Error, ingrese un valor correcto")
        return
    if opcion == 1:
        try:
            base = float(input("Ingrese un valor de la base : "))
            altura = float(input("Ingrese valor e la altura: "))
            figura =cuadrilatero(base,altura)
        except  ValueError:
            print("Ingrese valor correcto")
            return

    elif opcion == 2:
        try:
            base = float(input("Ingrese el valor de la base : "))
            altura = float(input("Ingrese el valor e la altura: "))
            figura =triangulo(base,altura)
        except  ValueError:
            print("Ingrese valor correcto para el triangulo")
            return

    elif opcion == 3:
        try:
            radio == float(input("Ingrese el valor del radio"))
            figura = circulo(radio)
        except ValueError:
            print("Ingrese valor correcto")
            return
    else:
        print("Opción no válida")
        return
    print(figura.descripcion())
    print(f"El area es :{figura.area(): .2f}")

if __name__=="__main__":
    main()

