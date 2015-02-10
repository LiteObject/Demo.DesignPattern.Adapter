package com.LiteObject;

/**
 * Created by M on 2/10/2015.
 */
public class StarWarsBook {

    private String name = "Revenge of the Sith";
    private int pageCount = 480;

    String getBookName(){
        return this.name;
    }

    int getPageCount(){
        return this.pageCount;
    }
}
