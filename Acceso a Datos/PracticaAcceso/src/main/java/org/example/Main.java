package org.example;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    static Scanner teclado =new Scanner(System.in);
    static AventuraJABX aventura = new AventuraJABX();

    public static void main(String[] args) throws JAXBException, IOException {

        System.out.println("                                                 /===-_---~~~~~~~~~------____\n" +
                "                                                |===-~___                _,-'\n" +
                "                 -==\\\\                         `//~\\\\   ~~~~`---.___.-~~\n" +
                "             ______-==|                         | |  \\\\           _-~`\n" +
                "       __--~~~  ,-/-==\\\\                        | |   `\\        ,'\n" +
                "    _-~       /'    |  \\\\                      / /      \\      /\n" +
                "  .'        /       |   \\\\                   /' /        \\   /'\n" +
                " /  ____  /         |    \\`\\.__/-~~ ~ \\ _ _/'  /          \\/'\n" +
                "/-'~    ~~~~~---__  |     ~-/~         ( )   /'        _--~`\n" +
                "                  \\_|      /        _)   ;  ),   __--~~\n" +
                "                    '~~--_/      _-~/-  / \\   '-~ \\\n" +
                "                   {\\__--_/}    / \\\\_>- )<__\\      \\\n" +
                "                   /'   (_/  _-~  | |__>--<__|      |\n" +
                "                  |0  0 _/) )-~     | |__>--<__|      |\n" +
                "                  / /~ ,_/       / /__>---<__/      |\n" +
                "                 o o _//        /-~_>---<__-~      /\n" +
                "                 (^(~          /~_>---<__-      _-~\n" +
                "                ,/|           /__>--<__/     _-~\n" +
                "             ,//('(          |__>--<__|     /                  .----_\n" +
                "            ( ( '))          |__>--<__|    |                 /' _---_~\\\n" +
                "         `-)) )) (           |__>--<__|    |               /'  /     ~\\`\\\n" +
                "        ,/,'//( (             \\__>--<__\\    \\            /'  //        ||\n" +
                "      ,( ( ((, ))              ~-__>--<_~-_  ~--____---~' _/'/        /'\n" +
                "    `~/  )` ) ,/|                 ~-_~>--<_/-__       __-~ _/\n" +
                "  ._-~//( )/ )) `                    ~~-'_/_/ /~~~~~~~__--~\n" +
                "   ;'( ')/ ,)(                              ~~~~~~~~~~\n" +
                "  ' ') '( (/\n" +
                "    '   '  `\n" +
                "\n" +
                "-----------------------------------------------------------------------------------\n");
        System.out.println("\n" +
                "     _                             _                              \n" +
                "    / \\    __   __   ___   _ __   | |_   _   _   _ __    __ _     \n" +
                "   / _ \\   \\ \\ / /  / _ \\ | '_ \\  | __| | | | | | '__|  / _` |    \n" +
                "  / ___ \\   \\ V /  |  __/ | | | | | |_  | |_| | | |    | (_| |    \n" +
                " /_/   \\_\\   \\_/    \\___| |_| |_|  \\__|  \\__,_| |_|     \\__,_|    \n" +
                "                                                                  \n" +
                "  ____                                           _                \n" +
                " |  _ \\   _ __    __ _    __ _    ___    _ __   (_)   ___    __ _ \n" +
                " | | | | | '__|  / _` |  / _` |  / _ \\  | '_ \\  | |  / __|  / _` |\n" +
                " | |_| | | |    | (_| | | (_| | | (_) | | | | | | | | (__  | (_| |\n" +
                " |____/  |_|     \\__,_|  \\__, |  \\___/  |_| |_| |_|  \\___|  \\__,_|\n" +
                "                         |___/                                    \n");



        realizarLecturaXML("C:\\Users\\FP\\Desktop\\Practica Acceso\\XMLPractica.xml");

        //realizarGuardadoXML(lista,"C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\generadoXMLJABX.xml");
    }

    private static AventuraJABX realizarLecturaXML(String ruta) throws JAXBException {

        int escena = 0;
        boolean fin = false;

        File file = new File(ruta);

        if (file.exists()) {
            JAXBContext jaxbContext = JAXBContext.newInstance(AventuraJABX.class);
            Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();

            aventura = (AventuraJABX) jaxbUnmarshaller.unmarshal(file);
            //System.out.println(aventura.getEscenas().get(0).getTexto());


           while(!fin){

               imprimirEscena(escena);

               do{
                   try{
                       escena = teclado.nextInt();
                       if (escena <=0 || escena >3 ){
                           System.out.println("Introduce una opcion valida");
                       }

                   }catch (Exception e){
                       System.out.println("Has escogido una opcion no valida");
                       break;
                   }
               }while(escena <=0 || escena >3);



            //fin = true;

           }


        } else {
            System.out.println("No se ha podido encontrar el fichero indicado");
        }


        return aventura;

    }

    private static void imprimirEscena(int cod){

        //for each para recorres las escenas
        for(EscenaJABX escena1: aventura.getEscenas()){
            //if para coger la escena del codigo que te pasen
            if(escena1.getCodigo() == cod){
                System.out.println(escena1.getTexto());
                //for each para recorrer las opciones de la escena que esta seleccionada
                for(OpcionesJABX opcion1 : escena1.opciones ){
                    System.out.println(opcion1.getId() +"-"+ opcion1.getTexto());
                }
            }
        }
    }

}