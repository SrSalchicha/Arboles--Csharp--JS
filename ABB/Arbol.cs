//Jorge Brandon Chandomi Esponda Arbol Binario Generico C#
public class Arbol<T>{

    Nodo<T> Raiz;
    // Constructor por defecto de el arbol binario
    public Arbol(){
        Raiz = null;
    }

    // Añadir nuevo nodo
    public void Anadir(T dato){
        Nodo<T> nuevoNodo = new Nodo<T>();
        //Crear nuevo nodo
        nuevoNodo.Data = dato;
        nuevoNodo.HijoDerecho = null;
        nuevoNodo.HijoIzquierdo = null;
        // Evaluar el nuevo nodo para colocarlo en el arbol binario
        if (Raiz == null) Raiz = nuevoNodo;
        else{
            Nodo<T> Anterior = null, Recorre = Raiz;
            //Si el siguiente nodo no esta vacio continua recorriendo el arbol
            while(Recorre != null){
                Anterior = Recorre;
                if(dato.ToString().CompareTo(Recorre.Data.ToString()) > 0){
                    Recorre = Recorre.HijoDerecho;
                }
                else{
                    Recorre = Recorre.HijoIzquierdo;
                }
            }
            //Evalua el ultimo nodo para colocar el nuevo nodo
            if(dato.ToString().CompareTo(Anterior.Data.ToString()) > 0){
                Anterior.HijoDerecho = nuevoNodo;
            }
            else{
                Anterior.HijoIzquierdo = nuevoNodo;
            }
        }        
    }
}