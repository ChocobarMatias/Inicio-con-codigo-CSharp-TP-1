Proceso TP_N_1_Ejercicio_8
	Definir  nota1, nota2, nota3, promedio Como Real;
	
	Escribir " Ingresar Primera Nota: ";
	Leer nota1;
	Escribir " Ingresar Segunda Nota: ";
	Leer nota2;
	Escribir  " Ingresar Tercera Nota: ";
	Leer nota3;
	
	promedio = (nota1 + nota2 + nota3) / 3;
	
	si (promedio >= 7) Entonces
		Escribir  " Alumno Promocionado ", promedio;
	FinSi

FinProceso
