package com.met.spring;

public class Employee {

	private static int count = 0;
	private int id;
	private int age;
	private String name;
	private double salary;
	
	private Address address;
		
	public Employee() {
		super();
		id = ++count;
		System.out.println("Default Employee instance created with ID: " + id);
	}
	
	public Employee(int age, String name, double salary) {
		this();
		this.age = age;
		this.name = name;
		this.salary = salary;
		
		System.out.println("Parameterized const for ID: " + id);
	}
	
	public Employee(int age, String name, double salary, Address address) {
		this();
		this.age = age;
		this.name = name;
		this.salary = salary;
		this.address = address;
		
		System.out.println("Parameterized const for ID: " + id);
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getSalary() {
		return salary;
	}

	public void setSalary(double salary) {
		this.salary = salary;
	}

	public int getId() {
		return id;
	}

	public Address getAddress() {
		return address;
	}

	public void setAddress(Address address) {
		this.address = address;
	}

	@Override
	public String toString() {
		return "Employee [id=" + id + ", age=" + age + ", name=" + name + ", salary=" + salary + ", address=" + address
				+ "]";
	}

	public double getAnnualSalary(){
		return salary * 12;
	}
	
	/*public static void main(String[] args) {
		
		Employee employee = new Employee();
		System.out.println(employee);
		
		
	}*/
	
}
