Feature: PlaceOrder

Positive and negative scenarios for place order

Background: 
	Given Initilize browser

@PlaceOrder
@Regression
Scenario: Validate place order
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	When Select product by name Samsung galaxy s6
	Then Validate product information name: Samsung galaxy s6 and price 360
	When Add product to cart
	Then Validate Alert message as Product added.
	When Go to cart
	When Place an order
		And Fill the place order form with data
			| name   | country | city      | creditCard | month | year |
			| Tester | England | Liverpool | 1298739823 | 11    | 2028 |
	Then Validate confirmation message
		And Validate confirmation information
			| name   | country | city      | creditCard | month | year |
			| Tester | England | Liverpool | 1298739823 | 11    | 2028 |

@PlaceOrder
@Regression
Scenario: Validate place order without required fields
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	When Select product by name Samsung galaxy s6
	Then Validate product information name: Samsung galaxy s6 and price 360
	When Add product to cart
	Then Validate Alert message as Product added.
	When Go to cart
	When Place an order
		And Fill the place order form with data
			| name   | country | city      | creditCard | month | year |
			|        | England | Liverpool |            | 11    | 2028 |
	Then Validate Alert message as Please fill out Name and CredirCard.