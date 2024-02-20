Feature: ProductInfo

Positive and negative scenarios for product information page

Background: 
	Given Initilize browser

@ProductInfo
@Regression
Scenario: Validate product information displayed
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	When Select product by name Samsung galaxy s6
	Then Validate product information name: Samsung galaxy s6 and price 360
