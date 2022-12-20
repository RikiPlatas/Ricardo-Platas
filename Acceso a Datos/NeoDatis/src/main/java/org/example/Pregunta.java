package org.example;

import java.util.ArrayList;

public class Pregunta {

    String texto;
    ArrayList<Opcion> opcion;

    public Pregunta(String texto, ArrayList<Opcion> opcion) {
        this.texto = texto;
        this.opcion = opcion;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    public ArrayList<Opcion> getOpcion() {
        return opcion;
    }

    public void setOpcion(ArrayList<Opcion> opcion) {
        this.opcion = opcion;
    }

    @Override
    public String toString() {
        return "Pregunta: " + texto + '\n' +
                  opcion + '\n' ;
    }
}
