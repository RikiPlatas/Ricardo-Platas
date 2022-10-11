package org.example;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class MascotaGSON {

    @SerializedName ("nombre")
    @Expose
    private String nombre;
    @SerializedName ("tipo")
    @Expose
    private String tipo;
    @SerializedName ("edad")
    @Expose
    private int edad;
    @SerializedName ("genero")
    @Expose
    private String genero;


    public MascotaGSON() {
    }


    public MascotaGSON(String nombre, String tipo, int edad, String genero) {
        this.nombre = nombre;
        this.tipo = tipo;
        this.edad = edad;
        this.genero = genero;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    @Override
    public String toString() {
        return "MascotaGSON{" +
                "nombre='" + nombre + '\'' +
                ", tipo='" + tipo + '\'' +
                ", edad=" + edad +
                ", genero='" + genero + '\'' +
                '}';
    }
}
