//Conversor de medidas de longitud
//Solicitar al usuario elejir una conversión
Algoritmo Ejercicio4_Conversor
	Definir op Como Entero
    Definir v Como Real
	
	Escribir "Conversor de medidads: "
    Escribir "1. Metros"
	Escribir "2. Pies"
	Escribir "3. Centimetros" 
	Escribir "4. Pulgadas"
    Leer op
	
    Escribir "Ingrese valor:"
    Leer v
	
    Segun op Hacer
        1: 
			Escribir v, " metros"
        2: 
			Escribir v * 3.28, " pies"
        3:
			Escribir v * 100, " cm"
        4: 
			Escribir v * 39.37, " pulgadas"
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
	
FinAlgoritmo
