@Sanity
Feature: TestLoginWithParameters

Feature to test login functionality with parameters
Background: 
	Given User is on login page


Scenario: Verify login functionality
	When User enters username and password
	And User clicks login button
	Then User is navigated to home page

Scenario Outline: Verify login with parameters
	When User enters "<username>" and "<password>"
	And User clicks login button
	Then User is navigated to home page
	Then User selected city and country information
	| city    | country |
	| delhi   | India   |
	| newyork | USA     |

Examples: 

| username | password |
| tom      | Harry    |
| jerry    | Mathew   |