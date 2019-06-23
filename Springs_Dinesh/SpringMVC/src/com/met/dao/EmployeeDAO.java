package com.met.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.List;

import javax.sql.DataSource;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.BeanPropertyRowMapper;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Component;

import com.met.domain.Employee;

@Component
public class EmployeeDAO {

	/*@Autowired
	private DataSource dataSource;*/
	
	@Autowired
	JdbcTemplate jdbcTemplate;
	
	public void saveEmployee(Employee employee){
		
		/*Connection con = null;
		PreparedStatement preparedStatement = null;
		
		try{
			con = dataSource.getConnection();
			preparedStatement = con.prepareStatement("insert into EmployeeTbl values (?, ?, ?, ?)");
			
			preparedStatement.setInt(1, employee.getId());
			preparedStatement.setString(2, employee.getName());
			preparedStatement.setString(3, employee.getDesignation());
			preparedStatement.setInt(4, employee.getAge());
			
			preparedStatement.executeUpdate();
			
		}catch(SQLException ex){
			ex.printStackTrace();
		}finally{
			if(preparedStatement != null){
				try {
					preparedStatement.close();
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
			}
			if(con != null){
				try{
					con.close();
				}catch(SQLException ex){
					ex.printStackTrace();
				}
			}
		}*/
		
		jdbcTemplate.update("insert into EmployeeTbl values (?, ?, ?, ?)",
					new Object[]{employee.getId(), employee.getName(),
							employee.getDesignation(), employee.getAge()});
		
	}
	
	public List<Employee> getAllEmployees(){
		
		List<Employee> listEmployees = jdbcTemplate.query("select * from EmployeeTbl",
					new BeanPropertyRowMapper<>(Employee.class));
		
		return listEmployees;
		
	}
	
}
