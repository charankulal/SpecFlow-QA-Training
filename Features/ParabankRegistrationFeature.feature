Feature: ParabankRegistrationFeature

Feature to test registration page of parabank

Background: 
	Given User is on home page of bank


@Sanity
Scenario Outline: Verify registration functionality with parameters
	Given User clicks on register link
	When User enters "<firstname>" and "<lastname>" and "<address>" and "<city>" and "<state>" and "<zip>" and "<phone>" and "<ssn>" and "<username>" and "<password>" and "<confirm>"
	And User clicks register button
	Then User enters dashboard page

Examples: 
| firstname | lastname | address | city      | state     | zip    | phone      | ssn    | username | password | confirm |
| charan    | kulal    | koppala | mangalore | karnataka | 543216 | 9108394592 | 123456 | ckulal1   | 123456   | 123456  |
	


