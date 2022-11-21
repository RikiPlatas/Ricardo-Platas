package empleadoCRUD;

import com.mongodb.client.MongoCollection;
import com.mongodb.client.model.Filters;
import converter.EmpleadoDocConverter;
import model.Empleado;
import org.bson.Document;

import javax.print.Doc;
import java.util.ArrayList;
import java.util.List;

import static converter.EmpleadoDocConverter.empleadoADoc;

public class EmpleadoDAO {

    EmpleadoDocConverter converter = new EmpleadoDocConverter();


    //Listar libros

    public List<Empleado> listarEmpleados(MongoCollection<Document> mongodb){

        List <Empleado> empleados = new ArrayList<>();

        List<Document> documentos = mongodb.find().into(new ArrayList<Document>());

        Empleado empleado;

        for(Document documento : documentos){
            empleado = converter.docAEmpleado(documento);

            empleados.add(empleado);
        }

        return empleados;
    }

    public  Empleado consultarEmpleado(MongoCollection<Document> mongoCollection,String nombre){
        Document documento = mongoCollection.find(Filters.eq("nombre", nombre)).first();
        return converter.docAEmpleado(documento);
            }

    public  void insertarEmpleado(MongoCollection<Document> mongoCollection, Empleado empleado){
        Document documento = empleadoADoc(empleado);

        try{
            //si ya existe no se permite la inserccion
            if(consultarEmpleado(mongoCollection, empleado.getNombre()) == null){
                mongoCollection.insertOne(documento);
            }else{
                System.out.println("Error: No se puede insertar" );
            }


        }catch (Exception e){
        e.printStackTrace();
        }
    }


    public void actualizarEmpleado(MongoCollection<Document> mongoCollection, Empleado empleado){

        Document documento = empleadoADoc(empleado);

        try{
            mongoCollection.replaceOne(Filters.eq("nombre",empleado.getNombre()), documento);
        }catch (Exception e){
            e.printStackTrace();
        }

    }

    public void  eliminarEmpleado(MongoCollection<Document> mongoCollection, String nombre){

        try {
            mongoCollection.deleteOne(Filters.eq("nombre",nombre));
        }catch (Exception e){
            e.printStackTrace();
        }

    }

}
