//Un programa que solicite un numero del 1 al 7
//Mostrar en pantalla los dias de la semana segun el numero
//ingresado
Algoritmo DIASSEMANA
	Escribir "*********************"
	Escribir "DIAS DE LA SEMANA"
	Escribir "*********************"
	
	//variable
	Definir dia Como Entero
	Escribir "Digite un valor numerico"
	Leer dia
	
	Segun dia Hacer
		1:
			Escribir "Lunes"
		2:
			Escribir "Martes"
		3:
			Escribir "Miercoles"
		4:
			Escribir "Jueves"
		5:
			Escribir "Viernes"
		6:
			Escribir "Sabado"
		7:
			Escribir "Domingo"
		De Otro Modo:
			Escribir "Digite un valor valido del 1 al 7"
	FinSegun
	
FinAlgoritmo
