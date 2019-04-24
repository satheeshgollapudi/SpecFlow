Feature: CancelEditLanguage

 Scenario: Check if the user could able to cancel editing a language
        Given I clicked on the Language tab under Profile page
        When I add a new language
        And I tried to click on Edit and click on cancel button
        Then that same language details should be displayed on my listing
