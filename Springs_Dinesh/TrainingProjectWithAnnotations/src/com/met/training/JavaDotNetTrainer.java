package com.met.training;

import java.util.List;

public class JavaDotNetTrainer {

	private String name;
	private List<String> subjects;
	
	public JavaDotNetTrainer(String name, List<String> subjects) {
		this();
		this.name = name;
		this.subjects = subjects;
	}

	public JavaDotNetTrainer() {
		super();
		
		System.out.println("JavaDotNet Trainer created");
		// TODO Auto-generated constructor stub
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public List<String> getSubjects() {
		return subjects;
	}

	public void setSubjects(List<String> subjects) {
		this.subjects = subjects;
	}

	
	public void train() {
		/*
		System.out.println("Participants are taking seats");
		System.out.println("Participants are  Switching off phones");
		*/
		System.out.println(name + " is teaching on JAVA Dotnet subjects " + subjects);
		/*
		System.out.print("Training completed");
		*/
		
	}

	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return name + " is a JavaDotNet Trainer";
	}
	
}

