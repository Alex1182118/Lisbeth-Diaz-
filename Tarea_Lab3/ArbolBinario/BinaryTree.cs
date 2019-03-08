﻿using System;
using System.Collections.Generic; using System.Linq; using System.Threading.Tasks;

namespace Tarea_Lab3.ArbolBinario
{
    public class BinaryTree<T>
    {
        private Nodo<T> Root;          public void CreateTree(string newkey, T valor)         {             if (Root == null) //Si el arbol esta vacio lo crea
            {
                //Recibe un nuevo nodo, tipo Nodo, que contiene la informacion 
                Nodo<T> newnode = new Nodo<T>();                 newnode.Info = valor; //Se le asigna la informacion                 newnode.name = newkey;                 Root = newnode; //La raiz es igual al primer nodo
            }             else
            {                 AddNode(valor, newkey, Root); //Si ya existe una raiz, se va a agregar nodo
            }         }          private void AddNode(T valor, string newkey, Nodo<T> nodo)
        {              Nodo<T> nodoadd = nodo;             if ((String.Compare(newkey, nodoadd.name, StringComparison.CurrentCultureIgnoreCase) == 1))//Si el nombre del nodo alfabeticamente es menor a la raiz, o al valor que recursivamente haya tomado, lo agrega a la iz)
            {                 if (nodoadd.Left == null) //Si esta vacio a la izquierda lo agrega
                {                     Nodo<T> nuevoNodo = new Nodo<T>();                     nuevoNodo.Info = valor;                     nuevoNodo.name = newkey;                     nodoadd.Left = nuevoNodo;                 }                 else                 {                     AddNode(valor, newkey, nodoadd.Left);//Si hay un nodo a la izquierda regresa a la funcion 
                }             }             else             {                 if (nodoadd.Right == null)                 {                     Nodo<T> nuevoNodo = new Nodo<T>();                     nuevoNodo.Info = valor;                     nuevoNodo.name = newkey;                     nodoadd.Right = nuevoNodo;                 }                 else                 {                     AddNode(valor, newkey, nodo.Right);                 }             }         }


    }
}
