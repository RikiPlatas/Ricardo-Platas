package org.example;

import org.neodatis.odb.ODB;
import org.neodatis.odb.ODBFactory;
import org.neodatis.odb.Objects;

import java.util.ArrayList;

public class PreguntaDAO {

    public void almacenar(Pregunta pregunta){
        ODB odb = null;

        try{
            odb = ODBFactory.open("C:\\PracticaAcceso3\\Preguntas.db");

            odb.store(pregunta);

        }catch (Exception e){
            e.printStackTrace();
        }finally {
            if(odb != null){
                try{
                    odb.close();
                }catch (Exception e){
                    e.printStackTrace();
                }
            }
        }
    }

    public ArrayList<Pregunta> listar(){
        ArrayList<Pregunta> preguntas = new ArrayList<Pregunta>();

        ODB odb = null;

        try{
            odb = ODBFactory.open("C:\\PracticaAcceso3\\Preguntas.db");
            Objects pregunta = odb.getObjects(Pregunta.class);

            while(pregunta.hasNext()){
                preguntas.add((Pregunta) pregunta.next());
            }

        }catch (Exception e){
            e.printStackTrace();
        }finally {
            if(odb != null){
                try{
                    odb.close();
                }catch (Exception e){
                    e.printStackTrace();
                }
            }
        }

        return preguntas;
    }

}

