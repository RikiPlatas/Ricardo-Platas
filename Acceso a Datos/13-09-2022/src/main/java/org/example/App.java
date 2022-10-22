package org.example;

import java.util.ArrayList;
import java.util.Scanner;

public class App {
    public static void main(String[] args) {
        ejercicio1();

        //ejercicio2();
    }

    public static void ejercicio1() {
        Scanner teclado = new Scanner(System.in);

        String StrMatricula = "";
        boolean longitud = false;

        System.out.println("Introduzca la matricula del vehiculo");
        StrMatricula = teclado.nextLine();

        if(comprobarLongitud(StrMatricula) == false){
            System.out.println("No se cumple el requisito de logitud");
        }




    }

    public static void ejercicio2() {
        Scanner teclado = new Scanner(System.in);
        int dorsal = 0;
        int temp = 0;
        int temp2 = 0;
        int suma = 0;


        System.out.println("Introduce el numero del dorsal");
        dorsal = teclado.nextInt();

        for (int i = 0; i < 100; i++) {
            temp = i / 10;
            temp2 = i % 10;


            if (temp * temp2 == dorsal) {
                suma = suma + 1;
            }
        }

        System.out.println(suma);

    }

    public static boolean comprobarLongitud(String matricula){
        boolean l = false;
        if( matricula.length() == 9){
            l = true;
        }
        return l;
    }

}

