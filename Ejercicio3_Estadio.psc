//Ingresar el sector del estadio deseado,
//Ingresar la cantidad de entras 
//Calcular el total a pagar por las entradas
Algoritmo Ejercicio3_Estadio
	Definir sector, cantidad Como Entero
    Definir precio, total Como Real
	
	Escribir "Sectores del estadio"
    Escribir "1. Palco"
	Escribir "2. Tribuna"
	Escribir "3. Preferencia" 
	Escribir "4. General"
    Leer sector
	
    Escribir "Cantidad de entradas:"
    Leer cantidad
	
    Segun sector Hacer
        1:
			precio = 300
        2: 
			precio = 125
        3:
			precio = 75
        4: 
			precio = 50
        De Otro Modo:
            Escribir "Esta opción de sector no es valida"
    FinSegun
	
    total = precio * cantidad
    Escribir "Total a pagar: Q.", total
	
FinAlgoritmo
