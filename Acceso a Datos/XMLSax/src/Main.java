import org.xml.sax.InputSource;
import org.xml.sax.XMLReader;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.XMLReaderFactory;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        try{
            XMLReader lector = XMLReaderFactory.createXMLReader();
            ParseadorAlumnosSAX parser = new ParseadorAlumnosSAX();
            lector.setContentHandler(parser);
            InputSource fichero = new InputSource("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\alumnosXML.xml");
            lector.parse(fichero);
            ArrayList<Alumno> lista = parser.obtenerResultado();
            System.out.println(lista.toString());


        }catch (Exception ex){
            System.out.println("Excepcion en el procesamiento del xml");
            ex.printStackTrace();
        }

    }
}