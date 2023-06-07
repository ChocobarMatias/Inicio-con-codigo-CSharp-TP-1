Proceso TP_N_1_Ejercicio_9
	
	Definir  numero1 Como Entero;
	Escribir  " Ingrese un numero entero positivo :";
	leer numero1;
	
	SI (numero1 < 10) entonces
	escribir " El numero tiene un Digito ";
	
SiNo
	
	SI (numero1 < 100) Entonces
		Escribir  " El numero tiene dos Digitos";
	SiNo
		SI (numero1 < 1000) Entonces
			Escribir " El numero tiene tres Digitos";
		SiNo
			Escribir " Error numero con muchos Digitos";
		FinSi
		
		
	FinSi
	
	
FinSi

FinProceso
