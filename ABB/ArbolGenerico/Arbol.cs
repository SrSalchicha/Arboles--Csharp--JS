//Jorge Brandon Chandomi Esponda Arbol Binario Generico C#
namespace ABB.ArbolGenerico;

public class Arbol<T> where T : IComparable<T>{
    //Creacion del nodo raiz
    public Nodo<T>? Raiz;

    // Añadir nuevo nodo
    public void Anadir(T dato){

        //Crear nuevo nodo
        Nodo<T> nuevoNodo = new Nodo<T>();
        nuevoNodo.Data = dato;

        // Evaluar el nuevo nodo para colocarlo en el arbol binario si la raiz esta vacia se añade a la raiz
        if (Raiz == null) Raiz = nuevoNodo;
        else{
            Nodo<T>? anterior = null, recorre = Raiz;
            //Si el siguiente nodo no esta vacio continua recorriendo el arbol
            while(recorre != null){
                anterior = recorre;
                recorre = (dato.CompareTo(recorre.Data) > 0) ? recorre.HijoDerecho : recorre.HijoIzquierdo;
            }
            //Evalua el ultimo nodo para colocar el nuevo nodo
            if(dato.CompareTo(anterior.Data) > 0){
                anterior.HijoDerecho = nuevoNodo;
            }
            else{
                anterior.HijoIzquierdo = nuevoNodo;
            }
        }        
    }

    //Recorrido del arbol en Pre orden
    public void PreOrden(Nodo<T>? raiz)
    {
        Console.Write(" | " + raiz.Data + " | ");
        if (raiz.HijoIzquierdo != null)
        {
            PreOrden(raiz.HijoIzquierdo);
        }
        if(raiz.HijoDerecho != null)
        {
            PreOrden(raiz.HijoDerecho);
        }
    }

    //Recorrido del arbol en orden
    public void InOrden(Nodo<T>? raiz)
    {
        if(raiz.HijoIzquierdo != null)
        {
            InOrden(raiz.HijoIzquierdo);
        }
        Console.Write(" | " + raiz.Data + " | ");
        if(raiz.HijoDerecho != null)
        {
            InOrden(raiz.HijoDerecho);
        }
    }

    //Recorrido del arbol en Post orden
    public void PostOrden(Nodo<T>? raiz)
    {
        if(raiz.HijoIzquierdo != null)
        {
            PostOrden(raiz.HijoIzquierdo);
        }
        if (raiz.HijoDerecho != null)
        {
            PostOrden(raiz.HijoDerecho);
        }
        Console.Write(" | " + raiz.Data + " | ");
    }

}

public class Nodo<T>
{
    public Nodo<T>? HijoDerecho;
    public Nodo<T>? HijoIzquierdo;
    public T? Data;
}