package org.example;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        ejercicio1();
    }

    public static void ejercicio1(){
        Scanner teclado = new Scanner(System.in);
        String StrMatricula = "";
        ArrayList<Character> matricula = new ArrayList<Character>();

        int dig1 = 0;
        int dig2 = 0;
        int temp = 0;

        System.out.println("Introduzca la matricula del vehiculo");
         StrMatricula = teclado.nextLine();

        for(int i = 0;i<StrMatricula.length();i++){
            matricula.add(StrMatricula.charAt(i));
        }

        if(matricula.size() == 9){
            for(int i = 0;i<matricula.size();i++){
                if(matricula.get(i) >=0 && matricula.get(i) <10){
                    dig1 = matricula.get(i);
                    System.out.println("guardado");
                }else{
                    System.out.println("Matricula Invalida");
                }
            }
        }else{
            System.out.println("Matricula Ivalida");
        }



    }
}
