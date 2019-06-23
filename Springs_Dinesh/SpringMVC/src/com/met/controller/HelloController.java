package com.met.controller;

import org.springframework.stereotype.Component;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@RequestMapping("/hello")
@Component
public class HelloController {

	@RequestMapping(method=RequestMethod.GET)
	public ModelAndView hello(){
		
		ModelAndView modelAndView = new ModelAndView();
		modelAndView.addObject("welcome", "Welcome to Spring MVC");
		
		modelAndView.setViewName("hello");
		
		
		return modelAndView;
	}
	
	@RequestMapping(value="queryparam", method=RequestMethod.GET)
	public ModelAndView paramHello(@RequestParam(name="userName") String name,
						@RequestParam int age){
		
		ModelAndView modelAndView = new ModelAndView();
		modelAndView.addObject("welcome", "Welcome to Spring MVC " + name + " and age: " + age );
		
		modelAndView.setViewName("hello");
		
		
		return modelAndView;
	}
	
	@RequestMapping(value="path/{name}", method=RequestMethod.GET)
	public ModelAndView pathHello(@PathVariable String name){
		
		ModelAndView modelAndView = new ModelAndView();
		modelAndView.addObject("welcome", "Welcome to Spring MVC " + name );
		
		modelAndView.setViewName("hello");
		
		
		return modelAndView;
	}
	
}
