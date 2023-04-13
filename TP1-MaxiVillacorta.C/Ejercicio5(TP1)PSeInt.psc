Algoritmo Escuela
	//Un colegio desea saber que porcentaje de niños y que porcentaje de niñas hay en el curso actual. Diseñar un programa para este proposito. Recuerda que para calcular el porcentaje puedes hacer una regla de 3 simples. El programa debe solicitar al usuario que ingrese la cantidad  total de niños y la cantidad total de niñas que hay en el curso/7
	Definir niños,niñas,total,porcniños,porcniñas Como Real;
	Escribir "Ingrese la cantidad de niños:";
	Leer niños;
	Escribir "Ingrese la cantidad de niñas:";
	Leer niñas;
	total=niños+niñas;
	porcniños=niños*100/total;
	porcniñas=niñas*100/total;
	Escribir "El total de alumnos es:", total;
	Escribir "El total de niños es:",niños;
	Escribir "El total de niñas es:",niñas;
FinAlgoritmo
