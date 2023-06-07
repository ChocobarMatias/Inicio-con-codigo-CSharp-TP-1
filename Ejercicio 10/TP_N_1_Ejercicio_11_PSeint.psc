Proceso  TP_N_1_Ejercicio_11
	Definir totalpregunta, contesto, porcentaje Como Entero;
	Escribir " Ingrese el Total de preguntas del Test de Capacitacion : ";
	Leer totalpregunta;
	Escribir  " Ingrese el Total de preguntas conestadas correctamente :";
	Leer contesto;
		
	porcentaje = (contesto * 100) / totalpregunta;
	
	SI (porcentaje >= 90) Entonces
		Escribir " Nivel Maximo : ",porcentaje,"%";
	SiNo
		SI (porcentaje >= 70 & porcentaje < 90) Entonces
			Escribir " Nivel Medio : ",porcentaje, "%";
		SiNo
			si (porcentaje >= 50 & porcentaje < 70) Entonces
				Escribir  " Nivel Regular : ",porcentaje,"%";
			SiNo
				Escribir " Fuera del Nivel : ",porcentaje, "%";
			FinSi
		FinSi
		
	FinSi
	
	
FinProceso
