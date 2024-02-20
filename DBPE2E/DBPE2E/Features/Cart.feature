Feature: Cart

Positive and negative scenarios for cart

Background: 
	Given Initilize browser

@Cart
@Regression
Scenario: Validate product listed on cart
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	When Select product by name Samsung galaxy s6
	Then Validate product information name: Samsung galaxy s6 and price 360
	When Add product to cart
	Then Validate Alert message as Product added.
	When Go to cart
	Then Validate the product Samsung galaxy s6 is listed on cart

@Cart
@Regression
Scenario: Validate deleted product is no longer listed on cart
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	When Select product by name Samsung galaxy s6
	Then Validate product information name: Samsung galaxy s6 and price 360
	When Add product to cart
	Then Validate Alert message as Product added.
	When Go to cart
	Then Validate the product Samsung galaxy s6 is listed on cart
	When Delete product from cart by name Samsung galaxy s6
	Then Validate the product Samsung galaxy s6 is no longer listed on cart

@Cart
@Regression
Scenario: Validate total price from products listed on cart listed on cart
	Given Go to login
		And Login with credentials UserTest7 and pass Test123.
	When Select product by name Samsung galaxy s6
		And Add product to cart
		And Select product by name Nexus 6
		And Add product to cart
	Then Validate Alert message as Product added.
	When Go to cart
	Then Validate the product Samsung galaxy s6 is listed on cart
		And Validate the product Nexus 6 is listed on cart
	Then Validate total price
