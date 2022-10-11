package org.example;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Arrays;

public class Main {
    public static void main (String[] args ) throws FileNotFoundException {
        System.out.println(leerJSON("C:\\Users\\FP\\Desktop\\2 DAM\\Acceso a datos\\mascotasJSON.json").toString());
    }

    public static ArrayList<MascotaGSON> leerJSON(String ruta) throws FileNotFoundException {

        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().create();
        FileReader fr = new FileReader(ruta);
        MascotaGSON[] mascotas = gson.fromJson(fr, MascotaGSON[].class);
        return new ArrayList<MascotaGSON>(Arrays.asList(mascotas));

    }

        public static String generarJSON(ArrayList<MascotaGSON> listaMascotas) throws FileNotFoundException {
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().setPrettyPrinting().create();
        String json = gson.toJson(listaMascotas);
        return json;

    }

}