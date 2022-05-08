using System.Collections.Generic;
using System;

public class Nodo<T>{
    public Nodo<T> HijoDerecho;
    public Nodo<T> HijoIzquierdo;
    public T Data;
    public Nodo(){
        HijoDerecho = null;
        HijoIzquierdo = null;
        Data = default(T);
    }
}