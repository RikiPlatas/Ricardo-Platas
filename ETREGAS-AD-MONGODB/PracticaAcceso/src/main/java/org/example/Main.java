package org.example;

import com.mongodb.MongoClient;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import empleadoCRUD.EmpleadoDAO;
import model.Empleado;
import org.bson.Document;

import java.util.List;

public class Main {
    public static void main(String[] args) {
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();

        MongoClient mongoClient = null;







        try{

            mongoClient = new MongoClient("localhost",27017);
            MongoDatabase conexion =  mongoClient.getDatabase("PracticaAcceso");
            MongoCollection<Document> coleccion = conexion.getCollection("empleados");

            //INSERTAR EMPLEADOS
            //Alta es tipo de dato String porque los date daban problemas

            Empleado empleado1 = new Empleado("Miguel",32,true, "2000-01-01",1500);
            empleadoDAO.insertarEmpleado(coleccion, empleado1);
            Empleado empleado2 = new Empleado("Daniel",24,false, "2020-10-11",3500);
            empleadoDAO.insertarEmpleado(coleccion, empleado2);




/*
            //LISTAR EMPLEADOS

            List<Empleado> empleados = empleadoDAO.listarEmpleados(coleccion);

            System.out.println("LISTA DE EMPLEADOS");

            for(Empleado empleado: empleados){
                System.out.println(empleado.toString());
            }
*/

            //ACTUALIZAR EMPLEADO

            empleado2.setEdad(10);
            empleadoDAO.actualizarEmpleado(coleccion, empleado2);


            //CONSULTAR EMPLEADO

            Empleado empleadoConsultado = empleadoDAO.consultarEmpleado(coleccion,"Miguel");
            System.out.println("\nEmpleado consultado ->"+ empleadoConsultado.toString());


            //ELIMINAR EMPLEADO
            empleadoDAO.eliminarEmpleado(coleccion,"Miguel");

            //LISTAR TODOS LOS EMPLEADOS DE LA BBDD
            List<Empleado> empleados = empleadoDAO.listarEmpleados(coleccion);

            empleados = empleadoDAO.listarEmpleados(coleccion);
            System.out.println("\nLista empleados\n--------------------");

            for(Empleado empleado: empleados){
                System.out.println(empleado.toString());
            }

        }catch (Exception e){
            System.out.println("Error de conexion" +e.getCause().getMessage());
        }finally {
            if(mongoClient != null){
                mongoClient.close();
            }
        }
    }
}