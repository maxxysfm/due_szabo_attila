<%-- 
    Document   : books
    Created on : May 4, 2019, 8:41:52 AM
    Author     : P-013-21.hallgato
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <jsp:useBean id="book" class="beans.Book" scope="page"/>
    <jsp:setProperty name="book" property="*"/>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <!--
        <h1>Hello World!</h1>
        -->
        <form name="form1" method="GET">
            ISBN: <input type="text" name="ISBN"><br>
            Szerző: <input type="text" name="author"><br>
            Cím: <input type="text" name="title"><br>
            <input type="submit" name="insert" value="Beszúrás">
        </form>
        
        <form name="form2" method="GET">
            keresett ISBN: <input type="text" name="ISBN"><br>
            Szerző: <input type="text" name="author"><br>
            Cím: <input type="text" name="title"><br>
            <input type="submit" name="update" value="Update">
        </form>
        <form name="form2" method="GET">
            Törlendő ISBN: <input type="text" name="ISBN"><br>
            <input type="submit" name="delete" value="Törlés">
        </form>
        <br><br/>
        <jsp:getProperty name="book" property="ISBN"/>
        <jsp:getProperty name="book" property="author"/>
        <jsp:getProperty name="book" property="title"/>
        <br><br/>
        <%
            String ibutton = request.getParameter("insert");
            if (ibutton!=null)
            {
                book.addBook();
            }
            String ibuttonDelete = request.getParameter("delete");
            if (ibuttonDelete!=null)
            {
                book.deleteBook();
            }
            String ibuttonUpdate = request.getParameter("update");
            if (ibuttonUpdate!=null)
            {
                book.updateBook();
            }
        %>
        
        <%= 
        book.listBooks()
        %>

        
    </body>
</html>
