package com.met.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import com.met.dao.EmployeeDAO;
import com.met.domain.Employee;

@Component
public class EmployeeService {

	@Autowired
	EmployeeDAO employeeDAO;
	
	public void saveEmploye(Employee employee){
		//Do Data validation here
		
		if(employee.getAge() < 0){
			throw new IllegalArgumentException("Age cannot be < 0");
		}
		
		employeeDAO.saveEmployee(employee);
		
		
	}
	
	public List<Employee> getAllEmployees(){
		
		return employeeDAO.getAllEmployees();
		
	}
	
}
