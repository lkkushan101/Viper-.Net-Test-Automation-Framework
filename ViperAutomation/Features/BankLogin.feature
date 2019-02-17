Feature: BankLogin


@mytag
Scenario: Login into bank application
	Given I'm in the bank URL
	When I enter the user name and the password
	Then I should succesfully login
