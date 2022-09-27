import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

public class App {
    public static void main(String[] args){
        try{
            DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
            DocumentBuilder db = dbf.newDocumentBuilder();
            Document documento = db.parse("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\testXML.xml");

            Element raiz = documento.getDocumentElement();
            //elemento raiz del xml
            System.out.println(documento.getDocumentElement());

            NodeList listaAnimales = raiz.getElementsByTagName("animal");

            for(int i = 0;i<listaAnimales.getLength();i++){
                Node animal = listaAnimales.item(i);

                System.out.println("Animal "+i);
                System.out.println("===========");

                NodeList datosAnimal = animal.getChildNodes();

                Element elemento = (Element) animal;

                Node nodoNombre = elemento.getElementsByTagName("tipo").item(0);

                String valNombre = nodoNombre.getTextContent();

                System.out.println("Tipo "+ valNombre);

                for (int j = 0;j<datosAnimal.getLength();j++){
                    Node dato = datosAnimal.item(j);

                    if (dato.getNodeType() == Node.ELEMENT_NODE){
                        System.out.println(dato.getNodeName()+ ": ");

                    }
                }



            }

        }catch (Exception e){

        }
    }
}
