package com.data;
import java.io.*;

import javax.servlet.*;
import javax.servlet.http.*;

import java.sql.*;

public class Student extends HttpServlet {
	private static final long serialVersionUID = 1L;

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
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
        //BY Default Connection
        Connection  con=DriverManager.getConnection 
                     ("jdbc:mysql://localhost:3306/","root","");
          String queryDB = "create database "+dbname;
          int i;
          Statement sd = con.createStatement();
          i=sd.executeUpdate(queryDB);
          if(i>0)
          {
          	 con.close();
          	 Connection  con1=DriverManager.getConnection
                       ("jdbc:mysql://localhost:3306/"+dbname +"","root","");
          	 Statement sd1 = con1.createStatement();
          	 out.println("<html><body>Your Database sucessfully Created.<br>");
          
          	 String queryTB = "create table "+tablename +" ( name varchar(20),"+"enrol varchar(20),"+"password varchar(20),"+"emailid varchar(20) );";
          	 sd1.executeUpdate(queryTB);
          	 out.println("Your Table Created Sucssecfully..!!<br>");
         
          	PreparedStatement ps=con1.prepareStatement("insert into "+tablename +" values(?,?,?,?)");
            ps.setString(1, name);
            ps.setString(2, enrol);
            ps.setString(3, pass);
            ps.setString(4, email);
            int k =ps.executeUpdate();
            	if(k>0)
            	{
            		out.println("<br>Insert Query Exceuted Sucessfully..!!<br><a href=OP.html>Click Here for Database Operation Page</a></body></html>");
            	
            	}
            	else
            	{
            	out.println("<br>Insert Query Error</body></html>");
            	}      
          } //End of If Statement
          else
          		{
          		out.print("Something Wrong Happened..!!");
          		} 
          } //End of Try Block
          catch(Exception se)
          {
          	  out.println("Database already Exist or Query error !!");
              se.printStackTrace();
          }
  	
        }
    }