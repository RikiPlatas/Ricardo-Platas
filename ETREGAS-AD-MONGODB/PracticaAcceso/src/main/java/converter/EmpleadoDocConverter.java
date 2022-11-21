package converter;

import model.Empleado;
import org.bson.Document;

public class EmpleadoDocConverter {

    public static Document empleadoADoc(Empleado empleado){

        Document documento = null;

        if (empleado != null){
            documento = new Document();

            documento.put("nombre", empleado.getNombre());

            documento.put("edad", empleado.getEdad());

            documento.put("contratoFijo",empleado.isContratoFijo());

            documento.put("alta", empleado.getAlta());

            documento.put("sueldo", empleado.getSueldo());

        }

        return documento;

    }

    public static Empleado docAEmpleado(Document documento){


        Empleado empleado = null;


        if(documento != null){

            empleado = new Empleado();

            empleado.setNombre(documento.getString("nombre"));
            empleado.setEdad(documento.getInteger("edad"));
            empleado.setContratoFijo(documento.getBoolean("contratoFijo"));
            empleado.setAlta(documento.getString("alta"));
            empleado.setSueldo(documento.getDouble("sueldo"));
        }

        return empleado;
    }


}
