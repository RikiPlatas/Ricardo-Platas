package org.example;

public class Opcion {

    String texto;
    boolean acierto;

    public Opcion(String texto, boolean acierto) {
        this.texto = texto;
        this.acierto = acierto;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    public boolean isAcierto() {
        return acierto;
    }

    public void setAcierto(boolean acierto) {
        this.acierto = acierto;
    }

    @Override
    public String toString() {
        return
                texto + '\''
                ;
    }
}
