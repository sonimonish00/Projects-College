<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Java Server Pages</title>
</head>
<%!  //methods kind of thing
	public float percentage(int x,int y,int z)
	{
	 float p;
	 p = (x+y+z)/3;
		return(p);
	}

 int count=0;
%>

<body>

<h1>EXAMPLE OF SERVLET</h1>

<%  //any kind of operation or declaration
 String Username = request.getParameter("name");
 session.setAttribute("SessionUserName", Username);
 pageContext.setAttribute("pageContextUsername", Username);
 pageContext.setAttribute("pageContextUsername", Username, pageContext.PAGE_SCOPE);
%>

Username is : <%=Username%> 
<br>
Username from Session : <%= session.getAttribute("SessionUserName") %>
<br>
Username from Session : <%= pageContext.getAttribute("pageContextUsername") %>
</body>
</html>