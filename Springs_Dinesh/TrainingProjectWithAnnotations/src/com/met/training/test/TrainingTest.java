package com.met.training.test;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import com.met.training.JavaDotNetTrainer;
import com.met.training.Trainer;
import com.met.training.TrainingCompany;
import com.met.training.TrainingWorkshop;

public class TrainingTest {

	public static void main(String[] args) {
		
		AbstractApplicationContext context = new
				ClassPathXmlApplicationContext("training.xml");
		
		
		
		Trainer javaTrainer = context.getBean("javaTrainer1", Trainer.class);
		System.out.println(javaTrainer);
		//javaTrainer.train();
		
		System.out.println(javaTrainer.getClass());
		
		
		System.out.println("***********************************");
		
		TrainingCompany trainingCompany = context.getBean("metSolutions", TrainingCompany.class);
		System.out.println(trainingCompany);
		//trainingCompany.conductTraining();
		
		System.out.println("***********************************");
		
		TrainingWorkshop trainingWorkshop = context.getBean("softwareTrainingWorkshop", TrainingWorkshop.class);
		
		try{
			trainingWorkshop.conductWorkshop();
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}
		
		
		JavaDotNetTrainer javaDotNetTrainer = context.getBean("javaDotNetTrainer", JavaDotNetTrainer.class);
		System.out.println(javaDotNetTrainer.getClass());
		javaDotNetTrainer.train();
		
		
		
		context.close();
	}
	
	
	
	
	
}
