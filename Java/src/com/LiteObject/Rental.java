package com.LiteObject;

/**
 * Created by M on 2/10/2015.
 */
public class Rental implements Movie {

    Movie movie;

    public Rental(Movie movie){
        this.movie = movie;
    }

    @Override
    public String getTitle() {
        return this.movie.getTitle();
    }

    @Override
    public int getLength() {
        return this.movie.getLength();
    }
}
