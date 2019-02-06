Feature: Log into the account
	
Scenario: Successfully logged in
Given I opened my home page
And click the loginlink
When Enter email address and password
And click on sign
Then I will be logged in
 
 Scenario: Unsuccessful login
 Given I opened my home page
And click the loginlink
When Enter incorrect details for email address and password
And click on sign
Then I should get an error message 

