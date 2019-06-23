package com.met.training;

import org.aspectj.lang.annotation.After;
import org.aspectj.lang.annotation.AfterReturning;
import org.aspectj.lang.annotation.AfterThrowing;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;
import org.springframework.context.annotation.EnableAspectJAutoProxy;
import org.springframework.stereotype.Component;

@Aspect
@EnableAspectJAutoProxy
@Component
public class Participants {

	@Pointcut("execution(* *.train())")
	public void training(){}
	
	@Before("training()")
	public void switchMobilePhones(){
		System.out.println("Participants are switching mobile phones");
	}
	
	@Before("training()")
	public void takingSeats(){
		System.out.println("Participants are taking seats");
	}
	
	
	@AfterReturning("training()")		//commit
	public void trainingSuccess(){
		System.out.println("Training was success...");
	}
	
	@After("training()")		//finally
	public void trainingCOmpleted(){
		System.out.println("Training Completed...");
	}
	
	@AfterThrowing("training()")
	public void trainingFailure(){
		System.out.println("Training was failure");
	}
	
}
