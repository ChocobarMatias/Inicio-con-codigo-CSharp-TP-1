Proceso  TP_N_1_Ejercicio_7
	Definir  num1, num2, suma, diferencia, producto, div Como Real;
	
	Escribir  " Ingresar primer Numero :";
	leer num1;
	
	Escribir " Ingresar el segundo Numero :";
	leer num2;
	
	SI (num2 <> 0) Entonces
		SI (num1 > num2) Entonces
			suma = num1 + num2;
			diferencia = num1 - num2;
			Escribir " Suma de los dos numeros es: ", suma;
			Escribir  " Diferencia de los dos numeros es: ", diferencia;
		SiNo
			producto = (num1 * num2);
			div = num1 / num2;
			Escribir" Producto de los numeros es: ", producto;
			Escribir  " Division de los dos numeros es: ",div;
		FinSi
	SiNo
		Escribir  " No se puede dividir en 0 ";
	FinSi
	
FinProceso
