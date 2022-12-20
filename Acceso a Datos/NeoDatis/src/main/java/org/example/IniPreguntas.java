package org.example;

import org.neodatis.odb.ODB;
import org.neodatis.odb.ODBFactory;

import java.util.ArrayList;

public class IniPreguntas {
    public static void main(String[] args) {
        PreguntaDAO almacenarDAO = new PreguntaDAO();


        //opciones pregunta1
        ArrayList<Opcion> opciones = new ArrayList<Opcion>();
        opciones.add(new Opcion("Negro", false));
        opciones.add(new Opcion("Blanco", false));
        opciones.add(new Opcion("Azul", true));
        opciones.add(new Opcion("Amarillo", false));

        Pregunta pregunta1 = new Pregunta("De que color es el cielo", opciones);

        almacenarDAO.almacenar(pregunta1);

        //opciones pregunta2
        ArrayList<Opcion> opciones2 = new ArrayList<Opcion>();
        opciones2.add(new Opcion("Si", false));
        opciones2.add(new Opcion("No", false));
        opciones2.add(new Opcion("A vecess", false));
        opciones2.add(new Opcion("Ninguna de las anteriores es correcta", true));

        Pregunta pregunta2 = new Pregunta("Windows es un sistema operativo?", opciones2);

        almacenarDAO.almacenar(pregunta2);

        //opciones pregunta3
        ArrayList<Opcion> opciones3 = new ArrayList<Opcion>();
        opciones3.add(new Opcion("Si", false));
        opciones3.add(new Opcion("Casi", false));
        opciones3.add(new Opcion("No", false));
        opciones3.add(new Opcion("Mira por la ventana", true));

        Pregunta pregunta3 = new Pregunta("Hace sol?", opciones3);

        almacenarDAO.almacenar(pregunta3);

    }
}