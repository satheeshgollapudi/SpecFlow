Feature: DeleteLanguage

Scenario: Check if the user could able to delete a language
        Given I clicked on the Language tab under Profile page
        When I add a new language
        And Try to Delete the language
		 Then that language should not be displayed on my listings
