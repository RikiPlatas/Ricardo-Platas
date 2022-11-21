package model;

import java.time.LocalDateTime;
import java.util.Date;

public class Empleado {

    private String nombre;
    private int edad;
    private boolean contratoFijo;
    private String alta;
    private double sueldo;

    public Empleado() {
    }

    public Empleado(String nombre, int edad, boolean contratoFijo, String alta, double sueldo) {
        this.nombre = nombre;
        this.edad = edad;
        this.contratoFijo = contratoFijo;
        this.alta = alta;
        this.sueldo = sueldo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public boolean isContratoFijo() {
        return contratoFijo;
    }

    public void setContratoFijo(boolean contratoFijo) {
        this.contratoFijo = contratoFijo;
    }

    public String getAlta() {
        return alta;
    }

    public void setAlta(String alta) {
        this.alta = alta;
    }

    public double getSueldo() {
        return sueldo;
    }

    public void setSueldo(double sueldo) {
        this.sueldo = sueldo;
    }

    @Override
    public String toString() {
        return "Empleado{" +
                "nombre='" + nombre + '\'' +
                ", edad=" + edad +
                ", contratoFijo=" + contratoFijo +
                ", alta='" + alta + '\'' +
                ", sueldo=" + sueldo +
                '}';
    }
}
