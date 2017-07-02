package com.data;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;

import javax.servlet.ServletException;

import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

//@WebServlet("/drop_db")
public class drop_db extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
    public drop_db() {
        super();
    }
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		 PrintWriter out = response.getWriter();
			
	        String db_name = request.getParameter("database");
	    try{
	    		Class.forName("com.mysql.jdbc.Driver");

	    		Connection  con=DriverManager.getConnection
	                         ("jdbc:mysql://localhost:3306/","root","");
	    		String queryDB = "drop database "+db_name; 
	    		Statement sd = con.createStatement();
	    		sd.executeUpdate(queryDB);
	            out.println("<script>alert(\"Database Drop Successfully\");</script>");
	            out.println("<html><body><meta http-equiv=\"refresh\" content=\"0; url=OP.html\"></body></html>");
	           
	        }
	            catch(Exception se)
	            {
	            	out.println("Database doesn't Exist or Query error !!");
	                se.printStackTrace();
	            }
	  }
	
	}


