Feature: addingfourDemo
In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario Outline: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add more than four new languages <Language>
	Then fifth language should not get added

		Examples:
	| Language  |
	| Bengali   |
	| Malayalam |
	| Marati    |
	| Kashmiri  |
	| oriya     |