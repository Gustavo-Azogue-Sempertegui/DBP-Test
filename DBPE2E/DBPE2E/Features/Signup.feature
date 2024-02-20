Feature: Signup

positive and negative scenarios for signup

Background: 
 Given Initilize browser

@Signup
@Regression
Scenario: Positive scenario for signup
	Given Go to Signup
		And Signup with credentials UserTest and pass
	Then Validate Alert message as Sign up successful.

@Signup
@Regression
Scenario Outline: Negative scenarios for signup
	Given Go to Signup
		And Signup with credentials <username> and <password>
	Then Validate Alert message as <message>
Examples: 
	| username            | password | message                                |
	| UserTest7           | Test123. | This user already exist.               |
	|                     | Test123. | Please fill out Username and Password. |
	| UserTest            |          | Please fill out Username and Password. |
	| !@#$@%#$            | Test123. | Special characters not allowed         |
	| Select * from users | Test123. | scripting exception                    |

