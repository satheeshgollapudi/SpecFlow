Feature: AddingmorethanFourLanguages

Scenario Outline: scenario outline user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language <Language> by using scenario outline
	Then check not more than four languages are added

	Examples:
	| Language  |
	| Bengali   |
	| Malayalam |
	| oriya     |
	| punjabi   |