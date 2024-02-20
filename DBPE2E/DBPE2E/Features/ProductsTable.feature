Feature: ProductsTable

positive and negative scenarios for products

Background: 
	Given Initilize browser

@ProductsTable
@Regression
Scenario Outline: Validate product filtering
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	When filer products by <filter>
	Then Validate amount of products like <amount>
Examples: 
	| filter   | amount |
	| PHONES   | 7      |
	| LAPTOPS  | 6      |
	| MONITORS | 2      |
