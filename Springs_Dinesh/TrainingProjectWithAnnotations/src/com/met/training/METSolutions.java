package com.met.training;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Component;


/*<bean id="metSolutions" class="com.met.training.METSolutions" autowire="byType">

</bean>
*/

@Component("metSolutions")
public class METSolutions implements TrainingCompany{
	
	@Autowired
	//@Qualifier(value="javaTrainer1")
	private List<Trainer> trainers;
	
	public METSolutions(List<Trainer> trainers) {
		this();
		this.trainers = trainers;
	}

	public METSolutions() {
		super();
		System.out.println("METSolutions instance created..");
	}

	public List<Trainer> getTrainers() {
		return trainers;
	}

	public void setTrainers(List<Trainer> trainers) {
		this.trainers = trainers;
	}

	@Override
	public void conductTraining() {
		
		for(Trainer trainer : trainers){
			try{
				trainer.train();
			}catch(Exception ex){
				
			}
		}
		
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "METSolutions is a TrainingCompany";
	}
	
}
