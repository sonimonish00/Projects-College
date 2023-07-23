package com.data;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.sql.*;

//@WebServlet("/Update")
public class Update extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public Update() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
	
        String name =  request.getParameter("name");
        String enrol = request.getParameter("enrol");
        String pass =  request.getParameter("password");
        String email = request.getParameter("emailid");
        String dbname = request.getParameter("dbname"); 
        String tablename = request.getParameter("tablename"); 
        
        try{
        Class.forName("com.mysql.jdbc.Driver");
          	 Connection  con1=DriverManager.getConnection("jdbc:mysql://localhost:3306/"+dbname +"","root","");
          	 PreparedStatement ps = con1.prepareStatement("UPDATE " +tablename +" SET name= ?, emailid=?, password=? WHERE enrol = ?;");
          	 ps.setString(1, name);
          	 ps.setString(2, email);
          	 ps.setString(3, pass);
          	 ps.setString(4, enrol);
          	 int i = ps.executeUpdate();
          	 if(i>0)
          	 {
          		out.println("<script>alert(\"Table Updated Successfully\");</script>");
        	    out.println("<html><body><meta http-equiv=\"refresh\" content=\"0; url=OP.html\"></body></html>");
        	    	 
          	 }
          } //End of Try Block
          catch(Exception se)
          {
          	  out.println(se.getMessage());
          	  se.printStackTrace();
          }
		
		
		
		
		
	}

}
