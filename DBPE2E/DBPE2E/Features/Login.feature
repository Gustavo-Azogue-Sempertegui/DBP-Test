Feature: Login

Functional positive and negative scenarios

Background: 
 Given Initilize browser

@Login
@Regression
Scenario: Positive login scenario
	Given Login with credentials userTest and pass Pass123.
	When [action]
	Then [outcome]
