Proceso TP_N_1_Ejercicio_10
	Definir  numero1 Como Entero;
	Escribir " Ingresar un numero Entero :  ";
	Leer numero1;
		
	SI (numero1 == 0) Entonces
		Escribir " El numero es Nulo ";
	SiNo
		SI (numero1 > 0) Entonces
			Escribir  " El numero es Positivo ";
		SiNo
			Escribir  " El numero es Negativo ";
		FinSi
	FinSi
		
FinProceso
