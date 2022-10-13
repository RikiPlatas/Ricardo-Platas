package org.example;

import javax.xml.bind.annotation.XmlAttribute;

public class OpcionesJABX {

    private int id;

    private String texto;

    private int resultado;

    public int getId() {
        return id;
    }
@XmlAttribute
    public void setId(int id) {
        this.id = id;
    }

    public String getTexto() {
        return texto;
    }
@XmlAttribute
    public void setTexto(String texto) {
        this.texto = texto;
    }

    public int getResultado() {
        return resultado;
    }
@XmlAttribute
    public void setResultado(int resultado) {
        this.resultado = resultado;
    }

    @Override
    public String toString() {
        return "OpcionesJABX{" +
                "id=" + id +
                ", texto='" + texto + '\'' +
                ", resultado=" + resultado +
                '}';
    }
}
