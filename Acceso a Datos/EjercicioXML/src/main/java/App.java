import org.w3c.dom.*;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import java.io.File;
import java.util.ArrayList;

public class App {
    public static void main(String[] args) {

        ArrayList<Mascota> mascotas = new ArrayList<Mascota>();
        try {
            DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
            DocumentBuilder db = dbf.newDocumentBuilder();
            Document documento = db.parse("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\EjercicioXML.xml");

            Element raiz = documento.getDocumentElement();
            //elemento raiz del xml
            System.out.println(documento.getDocumentElement());

            //recoge todos los nodos que contengan "mascota"
            NodeList listaMascotas = raiz.getElementsByTagName("mascota");






            Element eMascota = documento.createElement("mascota");
            raiz.appendChild(eMascota);


            eMascota.setAttribute("Nombre", "Leo");

            Element eTipo = documento.createElement("tipo");
            eMascota.appendChild(eTipo);
            eTipo.appendChild(documento.createTextNode("Gato"));

            Element eEdad = documento.createElement("edad");
            eMascota.appendChild(eEdad);
            eEdad.appendChild(documento.createTextNode("12"));

            Element eGenero = documento.createElement("genero");
            eMascota.appendChild(eGenero);
            eGenero.appendChild(documento.createTextNode("Macho"));


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








/*
                System.out.println("Nombre " + valNombre);
                System.out.println("");

                System.out.println("Edad"+ valEdad);
                */

            }

            Mascota mascotaAdd = new Mascota();
            mascotaAdd.setNombre("Leo");
            mascotaAdd.setTipo("Gato");
            mascotas.add(mascotaAdd);

            for (Mascota mascota1 : mascotas){
                if(mascota1.getNombre() == "Churchill"){
                    mascota1.setGenero("Macho");
                }
                System.out.println(mascota1.toString());
            }


            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            transformer.setOutputProperty(OutputKeys.INDENT,"yes");
            transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount","3");
            DOMSource domSource = new DOMSource(documento);
            StreamResult resultado = new StreamResult(new File("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\EjercicioXML.xml"));
            transformer.transform(domSource,resultado);

        } catch (Exception e) {
            e.printStackTrace();
        }


    }
}
