Feature: Login

Functional positive and negative scenarios

Background: 
 Given Initilize browser

@Login
@Regression
Scenario: Positive login scenario
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	Then Validate user logged in UserTest7

@Login
@Regression
Scenario Outline: Negative login scenarios
	Given Go to login
		And Login with credentials <username> and pass <password>
	Then Validate Alert message as <message>
Examples: 
	| username            | password | message                               |
	| UserTest7           | Pass123  | Wrong password.                       |
	| UserTest09          | Test123. | User does not exist.                  |
	|                     | Test123. | Please fill out Username and Password |
	| UserTest7           |          | Please fill out Username and Password |
	| @#$%@#$%            | Test123  | User does not exist.                  |
	| Select * from users | Test123  | User does not exist.                  |