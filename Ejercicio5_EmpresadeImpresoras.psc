//Solicitar ingresar la cantidad de impresores a comprar
//y seleccionar la forma de pago
//Mostrar los detalles de pago a realizar
Algoritmo Ejercicio5_EmpresadeImpresoras
	Definir cantidad Como Entero
    Definir precio, iva, subtotal, descuento, total Como Real
    Definir pago Como Entero
	
    precio = 650
    iva = precio * 1.12
	
    Escribir "Cantidad de impresoras:"
    Leer cantidad
	
	Escribir "Forma de pago: "
    Escribir "1. Efectivo"
	Escribir "2. Tarjeta"
	Escribir "3. Vale"
    Leer pago
	
    subtotal = cantidad * iva
	
    Segun pago Hacer
        1: 
			descuento = subtotal * 0.10
        2: 
			descuento = subtotal * 0.05
        3: 
			escuento = subtotal * 0.15
        De Otro Modo:
            descuento = 0
    FinSegun
	
    total = subtotal - descuento
	
    Escribir "Cantidad: ", cantidad
    Escribir "Precio con IVA: Q.", iva
    Escribir "Subtotal: Q.", subtotal
    Escribir "Descuento: Q.", descuento
    Escribir "Total a pagar: Q.", total
	
FinAlgoritmo
