package com.met.spring.test;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import com.met.spring.Address;
import com.met.spring.Employee;

public class SpringTest {

	public static void main(String[] args) {
		
		ApplicationContext context = new ClassPathXmlApplicationContext("spring.xml");
		
		System.out.println("****************Spring Container initialization completed*******************");
		
		Employee employee1 = context.getBean("employee1", Employee.class);
		System.out.println("employee1: " + employee1);
		
		Employee employee2 = context.getBean("employee2", Employee.class);
		System.out.println("employee2: " + employee2);
		
		Employee employee1Singleton = context.getBean("employee1", Employee.class);
		System.out.println("employee1Singleton: " +employee1Singleton);
		
		Employee employee3 = context.getBean("employee3", Employee.class);
		System.out.println("employee3: " + employee3);
		
		Employee employeePrototype = context.getBean("employee3", Employee.class);
		System.out.println("employeePrototype: " + employeePrototype);
		
		
		Employee employee4 = context.getBean("employee4", Employee.class);
		System.out.println("employee4: " + employee4);
		
		Employee employee5 = context.getBean("employee5", Employee.class);
		System.out.println("employee5: " + employee5);

		Employee employee6 = context.getBean("employee6", Employee.class);
		System.out.println("employee6: " + employee6);
		System.out.println("Annual Salary: " + employee6.getAnnualSalary());
		
		Address address1 = context.getBean("address1", Address.class);
		System.out.println(address1);
		
		
		Employee employee7 = context.getBean("employee7", Employee.class);
		System.out.println("employee7: " + employee7);
		System.out.println("Annual Salary: " + employee7.getAnnualSalary());
		
	}
	
	
	
}
