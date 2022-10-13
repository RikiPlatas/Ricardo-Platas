import org.xml.sax.InputSource;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import java.util.ArrayList;

public class App {
    public static void main(String[] args) {

        try{
            XMLReader lector = XMLReaderFactory.createXMLReader();
            ParseadorMascotasSAX parser = new ParseadorMascotasSAX();
            lector.setContentHandler(parser);
            InputSource fichero = new InputSource("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\EjercicioXML.xml");
            lector.parse(fichero);
            ArrayList<Mascota> lista = parser.obtenerResultado();
            System.out.println(lista.toString());


        }catch (Exception ex){
            System.out.println("Excepcion en el procesamiento del xml");
            ex.printStackTrace();
        }

    }
}