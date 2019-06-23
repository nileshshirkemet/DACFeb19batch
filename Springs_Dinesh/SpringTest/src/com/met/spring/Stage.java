package com.met.spring;

public class Stage {

	private static Stage  stage = null;
	
	private Stage(){
		System.out.println("Private Stage constructor invoked..");
	}
	
	public static Stage getStage(){
		if(stage == null){
			stage = new Stage();
		}
		
		return stage;
	}
	
}
