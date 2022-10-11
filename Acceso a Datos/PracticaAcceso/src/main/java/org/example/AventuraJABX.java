package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

@XmlRootElement(name = "aventura")
public class AventuraJABX {

    private int titulo;

    ArrayList<EscenaJABX> escenas = new ArrayList<EscenaJABX>();


    public int getTitulo() {
        return titulo;
    }
@XmlAttribute
    public void setTitulo(int titulo) {
        this.titulo = titulo;
    }

    public ArrayList<EscenaJABX> getEscenas() {
        return escenas;
    }
@XmlElement (name = "escena")
    public void setEscenas(ArrayList<EscenaJABX> escenas) {
        this.escenas = escenas;
    }

    @Override
    public String toString() {
        return "AventuraJABX{" +
                "titulo=" + titulo +
                ", escenas=" + escenas +
                '}';
    }
}
