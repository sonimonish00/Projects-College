package com.data;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mysql.jdbc.CallableStatement;
import com.mysql.jdbc.Statement;
//@WebServlet("/drop_tb")
public class drop_tb extends HttpServlet  {
	private static final long serialVersionUID = 1L;
       
   
    public drop_tb() {
        super();
        
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		PrintWriter out = response.getWriter();
		String dbname = request.getParameter("dbname");
		String table = request.getParameter("table");
		try {	
		Class.forName("com.mysql.jdbc.Driver");
		
			 Connection  con1=DriverManager.getConnection
                     ("jdbc:mysql://localhost:3306/"+dbname +"","root","");
        	 CallableStatement stmt = (CallableStatement) con1.prepareCall("{call tdelete()}");
        	 //stmt.setString(1, table);
        	 stmt.execute();
        	 out.println("<html><body><script>alert(\"Database Table Drop Successfully\");</script>");
        	 out.println("<meta http-equiv=\"refresh\" content=\"0; url=OP.html\"></body></html>");
        	
		} catch (Exception e) {
			e.printStackTrace();
		}
		
	}

}
