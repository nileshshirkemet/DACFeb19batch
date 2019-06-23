package com.met.training;

public class SoftwareTrainingWorkshop implements TrainingWorkshop{

	private TrainingCompany trainingCompany;

	@Override
	public void conductWorkshop() {
		trainingCompany.conductTraining();
	}

	public TrainingCompany getTrainingCompany() {
		return trainingCompany;
	}

	public void setTrainingCompany(TrainingCompany trainingCompany) {
		this.trainingCompany = trainingCompany;
	}

	public SoftwareTrainingWorkshop(TrainingCompany trainingCompany) {
		this();
		this.trainingCompany = trainingCompany;
	}

	public SoftwareTrainingWorkshop() {
		super();
		System.out.println("SoftwareTrainingWorkshop instance created..");
	}
	
}
