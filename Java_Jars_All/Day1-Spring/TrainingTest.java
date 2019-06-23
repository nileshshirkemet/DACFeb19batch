package com.met.nonspring.test;

import java.util.ArrayList;
import java.util.List;

import com.met.spring.training.JavaTrainer;
import com.met.spring.training.METSolutions;
import com.met.spring.training.SoftwareTrainingWorkshop;
import com.met.spring.training.Trainer;
import com.met.spring.training.TrainingCompany;
import com.met.spring.training.TrainingWorkshop;

public class TrainingTest {

	public static void main(String[] args) {
		
		List<String> subjects = new ArrayList<String>();
		subjects.add("JDBC");
		subjects.add("JSP/SERVLETS");
		subjects.add("JPA");
		subjects.add("JNDI");
		
		Trainer trainer = new JavaTrainer("Suresh", subjects);
		
		System.out.println(trainer);
		
		
		TrainingCompany metSolutions = new METSolutions(trainer);
		System.out.println(metSolutions);
		
		TrainingWorkshop trainingWorkshop = new SoftwareTrainingWorkshop(metSolutions);
		trainingWorkshop.conductWorkshop();
		
		
	}
	
}
