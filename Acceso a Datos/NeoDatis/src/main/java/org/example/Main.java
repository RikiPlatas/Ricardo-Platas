package org.example;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner teclado=new Scanner(System.in);

        int cont = 0;
        int respuesta = 0;

        PreguntaDAO preguntaDAO = new PreguntaDAO();





        while(cont < preguntaDAO.listar().size())
        {
            System.out.println(preguntaDAO.listar().get(cont));
            cont++;

            System.out.println("escribe la respuesta (0-3)");
            respuesta = teclado.nextInt();

            if(preguntaDAO.listar().get(cont).getOpcion().get(respuesta).isAcierto() == true){
                System.out.println("Acierto");
            }else {
                System.out.println("Fallo");
            }
        }


    }
}