package org.example;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Main {
    static Scanner teclado = new Scanner(System.in);
    static AventuraJABX aventura = new AventuraJABX();

    public static void main(String[] args) throws JAXBException, IOException, InterruptedException {

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

        Thread.sleep(5000);

        System.out.println("\n" +
                " _             _____                                 _        _             _                                               \n" +
                "| |           |  __ \\                               | |      | |           | |                                              \n" +
                "| |     __ _  | |  \\/_   _  ___ _ __ _ __ __ _    __| | ___  | | ___  ___  | |__   ___ _ __ _ __ ___   __ _ _ __   ___  ___ \n" +
                "| |    / _` | | | __| | | |/ _ \\ '__| '__/ _` |  / _` |/ _ \\ | |/ _ \\/ __| | '_ \\ / _ \\ '__| '_ ` _ \\ / _` | '_ \\ / _ \\/ __|\n" +
                "| |___| (_| | | |_\\ \\ |_| |  __/ |  | | | (_| | | (_| |  __/ | | (_) \\__ \\ | | | |  __/ |  | | | | | | (_| | | | | (_) \\__ \\\n" +
                "\\_____/\\__,_|  \\____/\\__,_|\\___|_|  |_|  \\__,_|  \\__,_|\\___| |_|\\___/|___/ |_| |_|\\___|_|  |_| |_| |_|\\__,_|_| |_|\\___/|___/\n" +
                "                                                                                                                            \n" +
                "                                                                                                                            \n");


        realizarLecturaXML("C:\\Users\\FP\\Documents\\GitHub\\Ricardo-Platas\\Acceso a Datos\\PracticaAcceso\\XMLPractica.xml");

        //realizarGuardadoXML(lista,"C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\generadoXMLJABX.xml");
    }

    private static AventuraJABX realizarLecturaXML(String ruta) throws JAXBException {

        int escena = 0;
        int opcionELegida = 0;
        int res = 0;
        boolean fin = false;

        File file = new File(ruta);

        if (file.exists()) {
            JAXBContext jaxbContext = JAXBContext.newInstance(AventuraJABX.class);
            Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();

            aventura = (AventuraJABX) jaxbUnmarshaller.unmarshal(file);

            while (!fin) {

                EscenaJABX escenaActual = imprimirEscena(escena);

                do {
                    try {
                        opcionELegida = teclado.nextInt();
                        if (opcionELegida <= 0 || opcionELegida > 3) {
                            System.out.println("Introduce una opcion valida");
                        }

                    } catch (Exception e) {
                        System.out.println("Has escogido una opcion no valida");
                        break;
                    }
                } while (opcionELegida <= 0 || opcionELegida > 3);


                for (OpcionesJABX opcion : escenaActual.getOpciones()) {
                    if (opcionELegida == opcion.getId()) {
                        escena = opcion.getResultado();
                    }

                }


            }


        }
        return aventura;
    }


    private static EscenaJABX imprimirEscena(int cod) {


        EscenaJABX test = null;
        //for each para recorres las escenas
        for (EscenaJABX escena1 : aventura.getEscenas()) {
            //if para coger la escena del codigo que te pasen
            if (escena1.getCodigo() == cod) {
                System.out.println(escena1.getTexto());
                //for each para recorrer las opciones de la escena que esta seleccionada
                for (OpcionesJABX opcion1 : escena1.opciones) {
                    System.out.println(opcion1.getId() + "-" + opcion1.getTexto());

                }
                test = escena1;

            }


        }
        return test;
    }


}

