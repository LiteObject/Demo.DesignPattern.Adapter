package com.LiteObject;

public class Main {

    public static void main(String[] args) {

        Rental rentalItem = new Rental(new StarWarsMovie());
        System.out.println("Rental Item Title: " + rentalItem.getTitle());
        System.out.println("Rental Item Length: " + rentalItem.getLength());

        rentalItem = new Rental(new BookAdapter(new StarWarsBook()));
        System.out.println("Rental Item Title: " + rentalItem.getTitle());
        System.out.println("Rental Item Length: " + rentalItem.getLength());
    }
}
