Feature: Add Language
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

	Scenario: TC2 Check if user could able to add  maximum of 4 languages 
	Given I clicked on the Language tab under Profile page
	When I add 4 new Languages
	| Language | Level |
	|English  | Basic |
	| Telugu   | Basic |
	| Hindi    | Basic |
	| French   | Basic |
	Then all languages should be displayed on my listings
	
Scenario Outline: TC3 Check if the user gets a message to enter all details if missed Field while adding a language
		Given I clicked on the Language tab under Profile page
		When I add a new language by not entering one of the fields <Language> and <Level>
		Then there should be a pop up Please enter language and level
Examples: 
		| Language | Level |
		| English  |       |
		|          | Basic |


	
	

		

		