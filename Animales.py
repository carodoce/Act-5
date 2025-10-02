class animal:
    def descripcion(self):
        pass

    def caracteristicas(self):
        pass

class mamifero(animal):
    def descripcion(self):
        return "Animal de sangre caliente que amamanta a sus crías"

    def caracteristicas(self):
        return 2+4

class anfibio(animal):
    def descripcion(self):
        return "Animal capaz de vivir tanto en el agua como en la tierra"

    def caracteristicas(self):
        return 3/5

class reptil(animal):
    def descripcion(self):
        return "Animal de sangre fría que posee escamas"

    def caracteristicas(self):
        return 2**4/(23/5)

def main():
    print("Menú")
    print("1. Mamífero")
    print("2. Anfibio")
    print("3. Reptil")

    op = int(input("Seleccione una opción: "))

    if (op==1):
        animal = mamifero()
    elif (op==2):
        animal = anfibio()
    elif (op==3):
        animal = reptil()
    else:
        print("Opción no válida")
        return

    
    print("\n--- Resultado ---")
    print("Descripción:", animal.descripcion())
    print("Características (operación aritmética):", animal.caracteristicas())

main()
