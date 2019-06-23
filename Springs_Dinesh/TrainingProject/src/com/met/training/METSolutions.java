package com.met.training;

public class METSolutions implements TrainingCompany{
	
	private Trainer trainer;
	
	public METSolutions(Trainer trainer) {
		this();
		this.trainer = trainer;
	}

	public METSolutions() {
		super();
		System.out.println("METSolutions instance created..");
	}

	public Trainer getTrainer() {
		return trainer;
	}

	public void setTrainer(Trainer trainer) {
		this.trainer = trainer;
	}

	@Override
	public void conductTraining() {
		
		trainer.train();
		
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "METSolutions is a TrainingCompany";
	}
	
}
