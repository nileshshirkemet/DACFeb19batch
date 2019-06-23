<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="sf" uri="http://www.springframework.org/tags/form"%>    
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<sf:form modelAttribute="defaultObject">
		<table align="center" border="1">
			
			<tr>
				<td>ID: </td>
				<td><sf:input path="id" id="txt_id" /></td>
			</tr>
			<tr>
				<td>Designation: </td>
				<td><sf:input path="designation" id="txt_desg" /></td>
			</tr>
			<tr>
				<td>Name: </td>
				<td><sf:input path="name" id="txt_name" /></td>
			</tr>
			<tr>
				<td>Age: </td>
				<td><sf:input path="age" id="txt_age" /></td>
			</tr>
			<tr>
				<td colspan="2" align="center">
					<input type="submit" value="Save">
				</td>
			</tr>
		</table>
	</sf:form>
	
	${listEmployees }
	
		<%-- <table border="1" align="center">
			<tr>
				<th>ID</th>
				<th>Name</th>
				<th>Designation</th>
				<th>Age</th>
			</tr>
			<c:forEach var="emp" items="${listEmployees }">
			
				<tr>
					<td>${emp.id }</td>
					<td>${emp.name }</td>
					<td>${emp.designation }</td>
					<td>${emp.age }</td>
				</tr>
				
			
			</c:forEach>
		</table> --%>
</body>
</html>