import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

import java.util.ArrayList;

public class ParseadorMascotasSAX extends DefaultHandler {

    private ArrayList<Mascota> listado;
    private Mascota mascota;
    private String valorElemento;

    enum tiposNodo{
        MASCOTAS,
        MASCOTA,
        TIPO,
        EDAD,
        GENERO
    }

    public ParseadorMascotasSAX(){
        super();
    }

    @Override
    public void startDocument() throws SAXException{
        listado = new ArrayList<Mascota>();
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
        super.startElement(uri, localName, qName, attributes);
        if(localName != null){
            switch (tiposNodo.valueOf(localName.toUpperCase())){
                case MASCOTA:
                    mascota = new Mascota();
                    String tipo = attributes.getValue("tipo");
                    if(tipo!= null){
                        mascota.setTipo(tipo);
                    }
                    break;
            }
        }
    }

    @Override
    public void endElement(String uri, String localName,String qName) throws SAXException{
        if(localName!=null){
            switch (tiposNodo.valueOf(localName.toUpperCase())){
                case MASCOTA:
                    listado.add(mascota);
                    break;
                case TIPO:
                    mascota.setTipo(valorElemento);
                    break;
                case EDAD:
                    mascota.setEdad(Integer.parseInt(valorElemento));
                case GENERO:
                    mascota.setGenero(valorElemento);

            }
        }
    }


    @Override
    public void characters(char[] ch, int start, int length) throws SAXException{
        valorElemento = new String(ch,start,length);
    }


    public ArrayList<Mascota> obtenerResultado(){
        return listado;
    }
}
