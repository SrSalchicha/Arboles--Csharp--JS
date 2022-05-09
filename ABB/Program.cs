//JORGE BRANDON CHANDOMI ESPONDA
using ABB.ArbolGenerico;
using ABB;

Console.WriteLine("ARBOL BINARIO GENERICO EN C#");

Arbol<int> arbolito = new Arbol<int>();

arbolito.Anadir(1);
arbolito.Anadir(3);
arbolito.Anadir(0);
arbolito.Anadir(4);
arbolito.Anadir(88);

Console.WriteLine("Recorrido en orden uwu");
arbolito.InOrden(arbolito.Raiz);

Console.WriteLine(Environment.NewLine + "Arbol de espadas" + Environment.NewLine);

Espada espadita = new Espada("Espada de plata", 15);
Espada espada2 = new Espada("Espada de madera", 1);
Espada espada3 = new Espada("Espada de oro", 5);
Espada espada4 = new Espada("Homelo chino", 100);

Arbol<Espada> ArbolEspadas = new Arbol<Espada>();
ArbolEspadas.Anadir(espadita);
ArbolEspadas.Anadir(espada2);
ArbolEspadas.Anadir(espada3);
ArbolEspadas.Anadir(espada4);

ArbolEspadas.InOrden(ArbolEspadas.Raiz);


Console.WriteLine();
