package com.met.spring;

public class Address {

	private static int count = 0;
	private String id;
	private String city;
	private String country;
	
	public Address() {
		super();
		
		id = "A"+ ++count;
		System.out.println("Default address object created with ID: " + id);
	}

	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	public String getCountry() {
		return country;
	}

	public void setCountry(String country) {
		this.country = country;
	}

	public String getId() {
		return id;
	}

	@Override
	public String toString() {
		return "Address [id=" + id + ", city=" + city + ", country=" + country + "]";
	}
}
