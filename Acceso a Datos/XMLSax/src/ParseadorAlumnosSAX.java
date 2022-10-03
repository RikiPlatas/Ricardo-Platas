import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

import javax.swing.text.DefaultHighlighter;
import java.util.ArrayList;

public class ParseadorAlumnosSAX  extends DefaultHandler {

    private ArrayList<Alumno> listado;
    private Alumno alumno;
    private String valorElemento;

    enum tiposNodo{
        LISTAALUMNOS,
        ALUMNO,
        NOMBRE,
        EDAD
    }

    public ParseadorAlumnosSAX(){
        super();
    }

    @Override
    public void startDocument() throws SAXException{
        listado = new ArrayList<Alumno>();
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
        super.startElement(uri, localName, qName, attributes);
        if(localName != null){
            switch (tiposNodo.valueOf(localName.toUpperCase())){
                case ALUMNO:
                    alumno = new Alumno();
                    String nombre = attributes.getValue("nombre");
                    if(nombre!= null){
                        alumno.setNombre(nombre);
                    }
                    break;
            }
        }
    }

    @Override
    public void endElement(String uri, String localName,String qName) throws SAXException{
        if(localName!=null){
            switch (tiposNodo.valueOf(localName.toUpperCase())){
                case ALUMNO:
                    listado.add(alumno);
                    break;
                case NOMBRE:
                    alumno.setNombre(valorElemento);
                    break;
                case EDAD:
                    alumno.setEdad(Integer.parseInt(valorElemento));

            }
        }
    }


    @Override
    public void characters(char[] ch, int start, int length) throws SAXException{
        valorElemento = new String(ch,start,length);
    }


    public ArrayList<Alumno> obtenerResultado(){
        return listado;
    }
}
