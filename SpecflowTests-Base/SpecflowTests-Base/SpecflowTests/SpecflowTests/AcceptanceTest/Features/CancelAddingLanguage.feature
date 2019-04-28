Feature: CancelAddingLanguage

Scenario: Check if the user could able to cancel adding a language
        Given I clicked on the Language tab under Profile page
        When I cancel adding a new language
        Then cancelled language should not be displayed on my listings