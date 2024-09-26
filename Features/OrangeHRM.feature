Feature: OrangeHRM

Testing Orange HRM website login functionality

Scenario: Verify login for orange hrm website
	Given User is on orange hrm login page
	When User enters the "<username>" and "<password>"
	And User clicks submit button
	Then User is navigated to the home page

Examples: 
| username | password |
| Admin    | admin123 |

Scenario: Verify Inavlid login for Orange HRM Website
	Given User is on orange hrm login page
	When User enters the "<usr>" and "<pass>"
	And User clicks submit button
	Then User is displayed with error message
Examples: 
	| usr  | pass     |
	| ssjjsj	| vaahaha	|
