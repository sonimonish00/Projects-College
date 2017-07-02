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

/**
 * Servlet implementation class Update
 */
//@WebServlet("/Update")
public class Update extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Update() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
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
          	 Connection  con1=DriverManager.getConnection
                       ("jdbc:mysql://localhost:3306/"+dbname +"","root","");
          	 Statement sd1 = con1.createStatement();
          	 String queryTB = "UPDATE "+tablename +" SET name='"+name+"', emailid='"+email+"', password='"+pass+"' WHERE enrol="+enrol+";";
          	 sd1.executeUpdate(queryTB);
            out.println("<script>alert(\"Table Updated Successfully\");</script>");
    	    out.println("<html><body><meta http-equiv=\"refresh\" content=\"0; url=OP.html\"></body></html>");
    	       
          
         
          } //End of Try Block
          catch(Exception se)
          {
          	  out.println("Error !!");
          	  se.printStackTrace();
          }
		
		
		
		
		
	}

}
