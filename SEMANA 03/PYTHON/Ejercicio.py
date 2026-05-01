stock = 500
total_vendido = 0

venta = int(input("Unidades vendidas (0 para salir): "))

# El while continúa mientras no se ingrese el valor centinela 0
while venta != 0:
    # Validar que la venta no sea negativa
    if venta < 0:
        print("Error: cantidad no puede ser negativa.")
    # Validar que exista stock suficiente
    elif venta > stock:
        print(f"Error: stock insuficiente. Quedan {stock}")
    else:
        # Si la venta es válida, se descuenta del stock
        stock = stock - venta
        
        # Se acumulan solo las ventas válidas
        total_vendido = total_vendido + venta
        
        print(f"Venta registrada. Stock: {stock}")

    # Nueva lectura para actualizar la condición del while
    venta = int(input("Unidades vendidas (0 para salir): "))

print(f"Stock restante: {stock}")
print(f"Total vendido: {total_vendido}")