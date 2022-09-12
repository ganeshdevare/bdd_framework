Feature: Employee
In order to add, edit, delete employee records
As an admin
I want to modify employee details in dashboard

@tag1
Scenario Outline: Add Valid Employee
	Given I have browser with OrangeHRM
	When I enter username as "Admin"
	And I enter password as "admin123"
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I fill the add employee section
		| firstname   | middlename   | lastname   | employee_id | toggle_login_detail   | username   | password   | confirm_password  | status   |
		| <firstname> | <middlename> | <lastname> | <empid>     | <toggle_login_detail> | <username> | <password> | <confirmpassword> | <status> |
	And I click on save employee
	Then I should be navigated to personal details section with added employee records
Examples: 
| firstname | middlename | lastname | empid | toggle_login_detail | username  | password   | confirmpassword | <status  |
| Ramesh    | Suresh     | Kale     | 101   | on                  | ramesh123 | Ramesh@123 | Ramesh@123      | disabled |
| Ramesh2   | Suresh2    | Kale2    | 102   | on                  | ramesh124 | Ramesh@123 | Ramesh@123      | disabled |
	
