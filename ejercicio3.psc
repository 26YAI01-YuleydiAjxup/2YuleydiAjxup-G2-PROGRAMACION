//Ingrese una letra: A ? Excelente, B ? Bueno, C ? Regular,
//D ? Deficiente, F ? Reprovado
Algoritmo Ejercicio3
	Definir letra Como Caracter
	Escribir "CLASIFICACIÓN DE LETRAS POR RANGO"
	Escribir Sin Saltar"Digite una letra: "
	Leer letra
	
	//Variable
	Segun letra Hacer
		"A" o "a":
			Escribir "Excelente"
		"B" o "b":
			Escribir "Bueno"
		"C" o "c":
			Escribir "Regular"
		"D" o "d":
			Escribir "Deficiente"
		"F" o "f":
			Escribir "Reprovado"
		De Otro Modo:
			Escribir "Digite una letra valida entre A, B, C, D y F"
	Fin Segun
	
FinAlgoritmo
