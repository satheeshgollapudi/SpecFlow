Feature: EditLanguage


Scenario: Check if the user could able to edit a language
        Given I clicked on the Language tab under Profile page
        When I add a new language
        And Try to Edit the language and update
        Then that new language should be displayed on my listings
	