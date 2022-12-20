package org.example;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner teclado=new Scanner(System.in);

        int cont = 0;
        int respuesta = 0;
        int contAciertos = 0;
        int contFallos = 0;

        //para las preguntas en orden aleatorio
        int random = 0;


        PreguntaDAO preguntaDAO = new PreguntaDAO();

/*
        for(int i = 0;i<100;i++){
            random = (int)(Math.random()*preguntaDAO.listar().size()+0);
            System.out.println(random);
        }

*/


        while(cont < preguntaDAO.listar().size())
        {
            //preguntas en orden aleatorio
            ArrayList<Integer> numerosRandom = new ArrayList();

            do{
                random = (int)(Math.random()*preguntaDAO.listar().size()+0);
            }while (numerosRandom.ma)





            System.out.println(preguntaDAO.listar().get(random).getTexto());

            for (int i = 0; i<preguntaDAO.listar().get(cont).opcion.size();i++){
                System.out.println(i+")"+preguntaDAO.listar().get(cont).getOpcion().get(i).getTexto());
            }

            System.out.println("escribe la respuesta (0-3)");
            respuesta = teclado.nextInt();

            if(preguntaDAO.listar().get(cont).getOpcion().get(respuesta).isAcierto() == true){
                System.out.println("Acierto");
                contAciertos++;
            }else {
                System.out.println("Fallo");
                contFallos++;
            }
            cont++;

        }

        System.out.println("Has acertado "+contAciertos+" preguntas, y has fallado "+contFallos+" preguntas");


    }

}