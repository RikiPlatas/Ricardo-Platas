public class Alumno {
    private String nombre;
    private int edad;
    private double notaMedia;

    public Alumno() {

    }

    public Alumno(String nombre, int edad, double notaMedia) {
        this.nombre = nombre;
        this.edad = edad;
        this.notaMedia = notaMedia;
    }

    public String getnombre() {
        return nombre;
    }

    public int getEdad() {
        return edad;
    }

    public double getNotaMedia() {
        return notaMedia;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public void setNotaMedia(double notaMedia) {
        this.notaMedia = notaMedia;
    }

}
