package com.met.training;

import javax.annotation.PostConstruct;
import javax.annotation.PreDestroy;

import org.springframework.beans.factory.DisposableBean;
import org.springframework.beans.factory.InitializingBean;
import org.springframework.stereotype.Component;

//@Component
public class LifeCycleBean implements
			InitializingBean, DisposableBean{

	@Override
	public void destroy() throws Exception {
		
		//Destroy all connection inside connection pool
		
		System.out.println("DisposableBean  ::  destroy");
		
		
	}
	

	public LifeCycleBean() {
		super();
		System.out.println("LifeCycleBean instance created");
	}



	@Override
	public void afterPropertiesSet() throws Exception {
				//create connection inside connection pool
		
		System.out.println("InitializingBean :: afterPropertiesSet");
		
	}
	
	@PostConstruct
	public void customInit(){
		//create connection inside connection pool
		System.out.println("PostConstruct : myInit");
	}
	
	

	@PreDestroy
	public void customDestroy(){
		
		//CLose all open connections inside pool
		System.out.println("PreDestroy :: CustomDestroy");
	}
	
	public void myInit(){
		System.out.println("XML Initialization of Bean");
	}
	
	public void myDestroy(){
		System.out.println("XML Destruction of bean");
	}
	
	
}
