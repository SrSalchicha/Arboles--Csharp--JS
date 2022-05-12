//JORGE BRANDON CHANDOMI ESPONDA
using ABB.ArbolGenerico;
using ABB;

Console.WriteLine("ARBOL BINARIO GENERICO EN C#");
Arbol<int> arbolito = new Arbol<int>();


int? bucle;
do{
    Console.WriteLine("Ingrese un dato de tipo entero");
    arbolito.Anadir(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Desea seguir añadiendo mas datos?" +
    Environment.NewLine + "1 = si, 2 = no");
    bucle = Convert.ToInt32(Console.ReadLine());
    if(bucle == 2){
        break;
    }
}while(true);

int? Select = 4;

do
{

    Console.WriteLine("Seleccione el tipo de salida"
    + Environment.NewLine + "1 = En orden, 2 = Pos orden, 3 = Pre orden"
    );

   Select = Convert.ToInt32(Console.ReadLine());

    switch (Select)
    {
        case 1:
            arbolito.InOrden(arbolito.Raiz);
            break;
        case 2:
            arbolito.PostOrden(arbolito.Raiz);
            break;
        case 3:
            arbolito.PreOrden(arbolito.Raiz);
            break;
        default:
            Console.WriteLine("Dato incorrecto");
        break;
    }
}while (Select == 4);
arbolito.InOrden(arbolito.Raiz);
/*


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
*/
