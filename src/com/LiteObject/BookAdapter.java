package com.LiteObject;

/**
 * Created by M on 2/10/2015.
 */
public class BookAdapter implements Movie {

    StarWarsBook book;

    public BookAdapter(StarWarsBook book){
        this.book =  book;
    }

    @Override
    public String getTitle() {
        return book.getBookName();
    }

    @Override
    public int getLength() {
        return book.getPageCount();
    }
}
