//Calculadora de funciones trigonométricas
//Solicitar al usuario un angulo en grados
//Calcular una de las 3 funciones trigonométricas
Algoritmo Ejercicicio1_Calculadora
	Definir angulo, radio, resultado Como Real
    Definir op Como Entero
	
	Escribir "Funciones trigonometricas"
    Escribir "Ingrese un angulo en grados:"
    Leer angulo
	
	Escribir "Funciones trigonométricas básicas"
    Escribir "1. Seno"
	Escribir "2. Coseno"
	Escribir "3. Tangente"
    Leer op
	
	radio=angulo*pi/180
	
    Segun op Hacer
        1: 
			resultado= Sen(radio)
			Escribir "Seno:",resultado
        2: 
			resultado= Cos(radio)
			Escribir "Coseno:",resultado
        3: 
			resultado= Tan(radio)
			Escribir "Tangente:",resultado
		De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
	
FinAlgoritmo
