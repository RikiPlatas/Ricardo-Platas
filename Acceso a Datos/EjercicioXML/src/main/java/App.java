import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

public class App {
    public static void main(String[] args) {
        try {
            DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
            DocumentBuilder db = dbf.newDocumentBuilder();
            Document documento = db.parse("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\EjercicioXML.xml");

            Element raiz = documento.getDocumentElement();
            //elemento raiz del xml
            System.out.println(documento.getDocumentElement());

            //recoge todos los nodos que contengan "mascota"
            NodeList listaMascotas = raiz.getElementsByTagName("mascota");


            for (int i = 0; i < listaMascotas.getLength(); i++) {
                Node mascota = listaMascotas.item(i);

                System.out.println("Mascota " + i);
                System.out.println("===========");

                //por cada nodo mascota recoger sus hijos
                NodeList datosMascota = mascota.getChildNodes();

                //crear elemento por cada nodo hijo
                Element elemento = (Element) mascota;

                //acceder a el elemento que contenga el atributo "Nombre"
                Node nodoNombre = elemento.getAttributeNode("Nombre");

                //guardar el valor del atributo en una variable
                String valNombre = nodoNombre.getTextContent();

                Node nodoEdad = elemento.getElementsByTagName("edad").item(0);
                int valEdad = Integer.parseInt(nodoEdad.getTextContent());

                Node nodoTipo = elemento.getElementsByTagName("tipo").item(0);
                String valTipo = nodoTipo.getTextContent();

                Node nodoGenero = elemento.getElementsByTagName("genero").item(0);
                String valGenero = (nodoGenero!= null)?elemento.getTextContent():null;

                Mascota mascota1 = new Mascota(valNombre,valEdad,valTipo,valGenero);

                if(mascota1.getNombre() == "Churchill"){
                    mascota1.setGenero("Macho");
                }





/*
                System.out.println("Nombre " + valNombre);
                System.out.println("");

                System.out.println("Edad"+ valEdad);
                */

            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
