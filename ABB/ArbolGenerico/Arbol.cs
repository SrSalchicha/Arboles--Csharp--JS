//Jorge Brandon Chandomi Esponda Arbol Binario Generico C#
namespace ABB.ArbolGenerico;

public class Arbol<T> where T : IComparable<T>{
    //Creacion del nodo raiz 
    public Nodo<T>? Raiz;
    //Creacion del fake nodo en caso de que el tipo de dato sea de tipo entero y el primer dato ingresado sea 0
    private Nodo<T>? FakeNodo;
    // Añadir nuevo nodo
    public void Anadir(T dato){
        //Crear nuevo nodo
        Nodo<T> nuevoNodo = new Nodo<T>();
        nuevoNodo.Data = dato;

        // Evaluar el nuevo nodo para colocarlo en el arbol binario si la raiz esta vacia se añade a la raiz
        if (Raiz == null){
            //verificar si el tipo de dato ingresado es entero para usar fake nodo
            if (typeof(T) == typeof(int))
            {
                //verificar que el tipo de dato ingresado no sea 0
                if (dato.CompareTo(((T) Convert.ChangeType(0, typeof(T)))) == 0)
                {
                    FakeNodo = nuevoNodo;
                }
                else //En caso de que no sea 0 se ingresa en la raiz
                {
                    Raiz = nuevoNodo;
                }
            }
            //Evaluar el segundo nodo ingresado en caso de que se haya ingresado el fake nodo
            else{
                Raiz = nuevoNodo;
                if (FakeNodo != null)
                {
                    if (FakeNodo.Data.CompareTo(Raiz.Data) > 0)
                    {
                        Raiz.HijoDerecho = nuevoNodo;
                    }
                    else
                    {
                        Raiz.HijoIzquierdo = nuevoNodo;
                    }
                }
            }
        }
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