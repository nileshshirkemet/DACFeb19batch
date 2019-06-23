package com.met.controller;

import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

import com.met.domain.Employee;
import com.met.service.EmployeeService;

@Controller
@RequestMapping("/employee")
public class EmployeeController {

	@Autowired
	EmployeeService employeeService;
	
	//@RequestMapping(method=RequestMethod.GET)
	@GetMapping
	public ModelAndView initializeEmployee(){
		
		ModelAndView modelAndView = new  ModelAndView();
		Employee employee = new Employee();
		employee.setDesignation("FRESHER");
		
		modelAndView.addObject("defaultObject", employee);
		
		modelAndView.setViewName("employee");
		
		
		List<Employee> employees = employeeService.getAllEmployees();
		
		
		modelAndView.addObject("listEmployees", employees);
		
		
		
		return modelAndView;
	}
	
	@PostMapping
	public ModelAndView saveEmployee(@ModelAttribute Employee employee){
		
		ModelAndView modelAndView = new ModelAndView();
		
		modelAndView.addObject("defaultObject", new Employee());
		
		//System.out.println(employee);
		
		
		employeeService.saveEmploye(employee);
		
		
		return modelAndView;
		
	}
	
	@ExceptionHandler
	public ModelAndView handleException(Exception ex,
			HttpServletRequest request){
		
		ModelAndView modelAndView = new ModelAndView();
		
		String exception = ex.getMessage();
		String url = request.getRequestURI();
		
		modelAndView.addObject("url", url);
		modelAndView.addObject("message", exception);
		
		modelAndView.setViewName("error");
		
		return modelAndView;
		
		
	}
	
}
