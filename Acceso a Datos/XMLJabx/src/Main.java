import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) throws JAXBException, IOException {

       ArrayList<AlumnoJaxb> lista =  realizarLecturaXML("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\alumnosXML.xml");

       realizarGuardadoXML(lista,"C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\generadoXMLJABX.xml");
    }

    private static ArrayList<AlumnoJaxb> realizarLecturaXML(String ruta) throws JAXBException {

        File file = new File(ruta);
        ArrayList<AlumnoJaxb> alumnos = new ArrayList<AlumnoJaxb>();
        if (file.exists()) {
            JAXBContext jaxbContext = JAXBContext.newInstance(Alumnos.class);
            Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();

            Alumnos listaAlumnos = (Alumnos) jaxbUnmarshaller.unmarshal(file);
            alumnos = (listaAlumnos != null ? listaAlumnos.getListaAlumnos() : new ArrayList<AlumnoJaxb>());

        } else {
            System.out.println("No se ha podido encontrar el fichero indicado");
        }


        return alumnos;

    }

    private static void realizarGuardadoXML(ArrayList<AlumnoJaxb> alumnos, String ruta) throws JAXBException, IOException {

        File file = new File(ruta);
        if (file.exists()) {
            JAXBContext jaxbContext = JAXBContext.newInstance(Alumnos.class);
            Marshaller jaxbMarshaller = jaxbContext.createMarshaller();

            jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

            Alumnos al = new Alumnos();
            al.setListaAlumnos(alumnos);
            jaxbMarshaller.marshal(al, file);

        }

    }
}
