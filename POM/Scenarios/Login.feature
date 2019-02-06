	Feature: Login

	Background:
	Given I am on the home page

	@positive
	Scenario: Successful Login
	When I enter the login credentials "VidhyaVenugan" and "Ithika2015"
	Then I am successfully logged in
	@negative
	Scenario: Unsuccessful Login	
	When I enter the login credentials "VidhyaVenugan" and "Ithika"
	Then I get an error message