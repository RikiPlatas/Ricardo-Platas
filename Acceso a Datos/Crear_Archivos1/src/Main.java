import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException {


        //crear ficheros y comproabr si existen
        /*
        File directorio1 = new File("C:\\Users\\FP\\Desktop\\directorio1");

        if (directorio1.exists()) {
            System.out.println("Ya existe " + directorio1.getName());
        } else {
            directorio1.mkdir();
        }

        File directorio2 = new File("C:\\Users\\FP\\Desktop\\directorio2");

        if (directorio2.exists()) {
            System.out.println("Ya existe " + directorio2.getName());
        } else {
            directorio2.mkdir();
        }

        directorio2.mkdir();


        File fichero1 = new File("C:\\Users\\FP\\Desktop\\directorio1\\fichero1.txt");

        if (fichero1.exists()) {
            System.out.println("Ya existe " + fichero1.getName());
        } else {
            fichero1.createNewFile();
        }

        File fichero2 = new File("C:\\Users\\FP\\Desktop\\directorio1\\fichero2.txt");

        if (fichero2.exists()) {
            System.out.println("Ya existe " + fichero2.getName());
        } else {
            fichero2.createNewFile();
        }


        File fichero3 = new File("C:\\Users\\FP\\Desktop\\directorio2\\fichero3.txt");


        if (fichero3.exists()) {
            System.out.println("Ya existe " + fichero3.getName());
        } else {
            fichero3.createNewFile();
        }

        File fichero4 = new File("C:\\Users\\FP\\Desktop\\fichero4.txt");


        if (fichero4.exists()) {
            System.out.println("Ya existe " + fichero4.getName());
        } else {
            fichero4.createNewFile();
        }

*/

        //leer ficheros
        /*
        try {

            FileInputStream fichero = new FileInputStream("C:\\Users\\FP\\Desktop\\ficheroPrueba.txt");

            do {
                System.out.println(fichero.read());
            } while (fichero.read() != -1);

        } catch (Exception e) {
            e.printStackTrace();
        }


*/
/*
        //Escribir fichero en otro fichero
        FileInputStream fichero = new FileInputStream("C:\\Users\\FP\\Desktop\\ficheroPrueba.txt");

        FileOutputStream fichero1 = new FileOutputStream("C:\\Users\\FP\\Desktop\\ficheroEscrito.txt");

        int a = fichero.read();

        while (a != -1) {

            System.out.println(a);
            fichero1.write(a);
            a = fichero.read();
        }

*/

        FileReader file = new FileReader("C:\\Users\\FP\\Desktop\\notas.txt")

        BufferedReader fichero = new BufferedReader(new FileReader(file));
        int a = fichero.read();
        int sum = 0;
        int media = 0;
        int cont = 0;
        String file = "";

        while (a != -1) {

            System.out.println(a);
            a = fichero.read();
            sum = sum + a;
            cont++;
        }
        media = sum / cont;
    }

}
