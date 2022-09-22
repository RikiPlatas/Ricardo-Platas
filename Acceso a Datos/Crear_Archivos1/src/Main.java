import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.ArrayList;

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
/*
        FileReader Fnotas = null;
        BufferedReader bnotas = null;


        Fnotas = new FileReader("C:\\Users\\FP\\Desktop\\notas.txt");
        bnotas = new BufferedReader(Fnotas);

        StringBuilder todasNotas = new StringBuilder();
        String lineaNotas = bnotas.readLine();

        while (lineaNotas != null) {
            todasNotas.append(lineaNotas);
            lineaNotas = bnotas.readLine();
        }
        String[] notas = todasNotas.toString().split("[|]");

        double media = 0.0;
        for (String nota : notas) {
            media += Double.parseDouble(nota);
        }

        media = media / notas.length;

        System.out.println(media);
        
        */

        /*
        
        FileInputStream fis = null;
        FileOutputStream fos = null;

        InputStreamReader isr = null;
        OutputStreamWriter osr = null;

        try {
            String ficheroLeer = "C:\\Users\\FP\\Desktop\\FicheroConÑ.txt";
            String ficheroEscribir = "\u202AC:\\Users\\FP\\Desktop\\FicheroEscribirÑ.txt";

            fis = new FileInputStream(ficheroLeer);
            fos = new FileOutputStream(ficheroEscribir);

            isr = new InputStreamReader(fis, StandardCharsets.UTF_8);
            osr = new OutputStreamWriter(fos, "ISO_8859_1");

            int data = isr.read();

            while (data != -1) {

                char character = (char) data;
                data = isr.read();
            }


        } catch (Exception e) {
            System.out.println("Peto");
        } finally {
            try {
                if (isr != null) isr.close();
                if (osr != null) osr.close();
                if (fis != null) fis.close();
                if (fos != null) fos.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        ;
*/


        ArrayList<Alumno> alumnos = new ArrayList<Alumno>();

        alumnos.add(new Alumno("Paco      ", 32, 8.9));
        alumnos.add(new Alumno("Miguel    ", 12, 6.3));
        alumnos.add(new Alumno("Daniel    ", 32, 5.5));
        alumnos.add(new Alumno("Luis       ", 32, 9.7));

        RandomAccessFile raf = null;

        try {
            raf = new RandomAccessFile("C:\\Users\\FP\\Desktop\\Alumnos.txt", "rw");

            for (Alumno alumno : alumnos) {

                raf.writeChars(alumno.getnombre());
                raf.writeInt(alumno.getEdad());
                raf.writeDouble(alumno.getNotaMedia());
            }

            raf.seek(32);

            String nombre = "";
            int edad = 0;
            Double nota = 0.0;
            for (int i = 0; i < 10; i++) {
                nombre += raf.readChar();
            }
            edad += raf.readInt();
            nota += raf.readDouble();

            System.out.println(nombre + " " + edad + " " + nota);


        } catch (Exception e) {

        } finally {

            raf.close();

        }

    }


}
