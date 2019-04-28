Feature: Parameterisation

@mytag
Scenario: Check if user could able to add a language parameter
	Given I clicked on the Language tab under Profile page
	When I add a new language 'Telugu' by using parameter
	Then that language should be displayed on my listings

	
