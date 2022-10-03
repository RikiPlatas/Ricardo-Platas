public class Mascota {

    private String nombre;
    private int edad;
    private String tipo;


    /**
     *
     */
    public Mascota() {
    }

    /**
     *Constructor con todos los parametros
     * @param nombre nombre de la mascota
     * @param edad edad de la mascota
     * @param tipo tipo de la mascota
     */
    public Mascota(String nombre, int edad, String tipo) {
        this.nombre = nombre;
        this.edad = edad;
        this.tipo = tipo;
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

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    /**
     *
     * @return
     */
    @Override
    public String toString() {
        return "Mascota{" +
                "nombre='" + nombre + '\'' +
                ", edad=" + edad +
                ", tipo='" + tipo + '\'' +
                '}';
    }
}
