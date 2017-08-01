Feature: Create A Groupon Account
		 As a Groupon user 
		 I want to be able to create a Groupon Account

Background: Navigate to the Groupon Home Page
	Given I go to the Groupon HomePage

@SMOKE
Scenario: Successful Groupon Account
	Given I go to the Groupon HomePage
	When I Click on Sign up page
	Then the signup page should be displayed

@Navigation
Scenario: Navigate to Signup Account
When I create a new account
Then the Groupon user should be created
