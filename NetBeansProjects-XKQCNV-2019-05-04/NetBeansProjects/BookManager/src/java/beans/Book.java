/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package beans;

import java.beans.*;
import java.io.Serializable;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author P-013-21.hallgato
 */
public class Book implements Serializable {

    Connection conn=null;
    Statement stmt=null;
    ResultSet result=null;
    
    public Book() {
        try {
            conn = DriverManager.getConnection("jdbc:derby://localhost:1527/books","user1","user1");
            stmt = conn.createStatement();
        } catch (SQLException ex) {
            Logger.getLogger(Book.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public void addBook() throws SQLException
    {
        String sql = "INSERT INTO BOOKS (ISBN, AUTHOR, TITLE) \n" +
"	VALUES('"+ISBN+"','"+author+"','"+title+"')";
        stmt.executeUpdate(sql);
    }
    public void deleteBook() throws SQLException
    {
        String sql = "DELETE FROM BOOKS WHERE ISBN='"+ISBN+"'";
        stmt.executeUpdate(sql);
    }
    public void updateBook() throws SQLException
    {
        String sql = "UPDATE BOOKS "
                + "SET author='"+author+"',title = '"+title+"' "
                + "WHERE ISBN = '"+ISBN+"'";
        stmt.executeUpdate(sql);
    }
    
    
    private String ISBN;

    public String getISBN() {
        return ISBN;
    }

    public void setISBN(String ISBN) {
        this.ISBN = ISBN;
    }

    public String getISBNtoUpperCase() {
        return ISBN.toUpperCase();
    }
    private String author;

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    private String title;

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String listBooks() throws SQLException
    {
        String listOfBooks = "";
        String sql = "SELECT * FROM USER1.BOOKS";
        result = stmt.executeQuery(sql);
        while(result.next())
        {
            listOfBooks += "<br>"+result.getString("ISBN")+" "+result.getString("author")+" "+result.getString("title");
            //result.getString("ISBN")
        }
        return listOfBooks;
    }

}
