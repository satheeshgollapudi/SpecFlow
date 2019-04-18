Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

	Scenario: Check if the user could able to edit a language
        Given I clicked on the Language tab under Profile page
        When I add a new language
        And Try to Edit the language and update
        Then that new language should be displayed on my listings
	
	Scenario: Check if the user could able to cancel adding a language
        Given I clicked on the Language tab under Profile page
        When I cancel adding a new language
        Then that language should not be displayed on my listings

		 Scenario: Check if the user could able to cancel editing a language
        Given I clicked on the Language tab under Profile page
        When I add a new language
        And I tried to click on Edit and click on cancel button
        Then that same language details should be displayed on my listing


		Scenario: Check if the user could able to delete a language
        Given I clicked on the Language tab under Profile page
        When I add a new language
        And Try to Delete the language
		 Then that language should not be displayed on my listings
