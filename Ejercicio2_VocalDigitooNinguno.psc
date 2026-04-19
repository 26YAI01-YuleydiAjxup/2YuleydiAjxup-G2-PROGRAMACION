//Solicitar al usiario que ingrese un carácter
//Determinar si el carácter es vocal, digito o ninguno
Algoritmo Ejercicio2_VocalDigitooNinguno
	Definir c Como Caracter
	
	Escribir "Ingrese un caracter:"
    Leer c
	
    Segun c Hacer
		"0","1","2","3","4","5","6","7","8","9":
			Escribir "Es un digito"
		"a","e","i","o","u":
			Escribir "Es una vocal"
		De Otro Modo:
			Escribir "No es vocal ni digito"
	Fin Segun
	
FinAlgoritmo
