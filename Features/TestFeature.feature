Feature: Test Login functionality

Feature to test login functionality
@Sanity@Regression
Scenario: Verify login functionality
	Given User is on login page
	When User enters username and password
	And User clicks login button
	Then User is navigated to home page
