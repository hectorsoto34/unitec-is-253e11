double lado = 2;
double altura = 10;
double perimetro = Figura262E11.Perimetro(lado);
double area = Figura262E11.Area(lado);
double volumen = Figura262E11.Volumen(area, altura);
Console.WriteLine($"El perímetro de la base de un Paralelogramo de {lado}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de la base de un Paralelogramo de {lado}cm por lado es {area}cm2");
Console.WriteLine($"El volumen de un Paralelogramo con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");
