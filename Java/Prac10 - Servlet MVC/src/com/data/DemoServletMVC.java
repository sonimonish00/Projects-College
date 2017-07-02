package com.data;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import com.service.*;
/**
 * Servlet implementation class DemoServletMVC
 */
@WebServlet("/DemoServletMVC")
public class DemoServletMVC extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public DemoServletMVC() {
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
		// TODO Auto-generated method stub
		String username1 =  request.getParameter("username");
		String password1 = request.getParameter("password");
		
		authentication obj = new authentication();
		boolean val = obj.getAuth(username1,password1);
		if(val==true)
		{
			response.sendRedirect("LoginPass.jsp");
		}
		else
		{
			
			response.sendRedirect("LoginFail.jsp");
		}
	}

}
