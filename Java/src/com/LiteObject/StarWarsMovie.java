package com.LiteObject;

/**
 * Created by M on 2/10/2015.
 */
public class StarWarsMovie implements Movie {

    private String name = "THE FORCE AWAKENS";
    private int length = 112;

    @Override
    public String getTitle() {
        return this.name;
    }

    @Override
    public int getLength() {
        return this.length;
    }
}
