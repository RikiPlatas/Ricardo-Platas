import javafx.fxml.FXML;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;
@XmlRootElement(name = "listaALumnos")
public class Alumnos {

    private ArrayList<AlumnoJaxb> listaAlumnos;

    public void setListaAlumnos(ArrayList<AlumnoJaxb> listaAlumnos) {
        this.listaAlumnos = listaAlumnos;
    }
@XmlElement(name = "alumno")
    public ArrayList<AlumnoJaxb> getListaAlumnos() {
        return listaAlumnos;
    }

}
