/*
 Programa que genera una piramide 
 centrada de asteriscos
 de forma recursiva
*/
using System;
class Piramide{
    void imprime(int cont, int index){
        int i;
        // Se controla el nivel de la piramide con cont
        if(cont > 0){
            // Ciclo que empuja la piramide a la izquierda 
            for( i = 0; i < cont; i++){
                Console.Write(" ");
            }
            // Ciclo que genera la mitad izquierda de la piramide
            for( i = 0; i < index; i++){
                Console.Write("*");
            }
            // Ciclo que generq la mitad derecha de la piramide
            for( i = 0; i < index - 1; i++){
                Console.Write("*");
            }
            
            System.Console.WriteLine("");
            imprime(cont - 1, index + 1);
        }

        
    }

    public static void Main(string[] args){
        
        int i = 5;      // Nivel que tendra la piramide
        int index = 1;  // Control para los asteriscos

        Piramide p = new Piramide();
        p.imprime(i, index);
    }
}
