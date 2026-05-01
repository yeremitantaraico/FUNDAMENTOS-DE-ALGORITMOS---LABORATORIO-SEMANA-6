suma = 0
contador = 0
mayor = 0

# Se usa infinito para que la primera nota válida pueda convertirse en la menor
menor = float("inf")

nota = float(input("Ingrese nota (-1 para terminar): "))

# El while continúa mientras no se ingrese el valor centinela
while nota != -1:
    # Validar que la nota esté dentro del rango permitido
    if nota < 0 or nota > 20:
        print("Nota inválida. Debe estar entre 0 y 20.")
    else:
        # Solo las notas válidas se suman y se cuentan
        suma = suma + nota
        contador = contador + 1

        # Actualizar la nota mayor si corresponde
        if nota > mayor:
            mayor = nota

        # Actualizar la nota menor si corresponde
        if nota < menor:
            menor = nota

    # Nueva lectura para que la condición del while pueda cambiar
    nota = float(input("Ingrese nota (-1 para terminar): "))

# Se verifica que exista al menos una nota válida antes de dividir
if contador > 0:
    promedio = suma / contador

    print(f"Notas ingresadas: {contador}")
    print(f"Nota más alta: {mayor}")
    print(f"Nota más baja: {menor}")
    print(f"Promedio: {promedio:.2f}")
else:
    print("No se ingresaron notas válidas.")