//Solicitar dos numero y una opcion matematica
//Mostrar el resultado de la opcion elegida
Algoritmo OperacionesBasicas_Ejercicio2enClase
    Definir a,b Como Real
    Definir op Como Entero
	
    Escribir "Ingrese dos numeros:"
    Leer a
	Leer b
	
	Escribir "Opción de operaciones"
    Escribir "1. Sumar"
	Escribir "2. Restar"
	Escribir "3. Multiplicar" 
	Escribir "4. Dividir"
    Leer op
	
    Segun op Hacer
        1: Escribir "Resultado:", a+b
        2: Escribir "Resultado:", a-b
        3: Escribir "Resultado:", a*b
        4:
            Si b<>0 Entonces
                Escribir "Resultado:", a/b
            Sino
                Escribir "Error: division por cero"
            FinSi
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
	
FinAlgoritmo
