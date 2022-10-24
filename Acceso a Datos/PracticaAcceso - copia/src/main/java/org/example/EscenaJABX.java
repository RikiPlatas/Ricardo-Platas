package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import java.util.ArrayList;

public class EscenaJABX {

    private int codigo;

    private String texto;

    ArrayList<OpcionesJABX> opciones = new ArrayList<>();

    public int getCodigo() {
        return codigo;
    }
@XmlAttribute
    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getTexto() {
        return texto;
    }
@XmlElement
    public void setTexto(String texto) {
        this.texto = texto;
    }

    public ArrayList<OpcionesJABX> getOpciones() {
        return opciones;
    }
@XmlElement (name = "opcion")
    public void setOpciones(ArrayList<OpcionesJABX> opciones) {
        this.opciones = opciones;
    }

    @Override
    public String toString() {
        return "EscenaJABX{" +
                "codigo=" + codigo +
                ", texto='" + texto + '\'' +
                ", opciones=" + opciones +
                '}';
    }
}
