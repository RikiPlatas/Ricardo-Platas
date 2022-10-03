public class Mascota {
    private String tipo;
    private int Edad;

    private String genero;

    public Mascota() {
    }

    public Mascota(String tipo, int edad, String genero) {
        this.tipo = tipo;
        Edad = edad;
        this.genero = genero;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getEdad() {
        return Edad;
    }

    public void setEdad(int edad) {
        Edad = edad;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    @Override
    public String toString() {
        return "Mascota{" +
                "tipo='" + tipo + '\'' +
                ", Edad=" + Edad +
                ", genero='" + genero + '\'' +
                '}';
    }
}
