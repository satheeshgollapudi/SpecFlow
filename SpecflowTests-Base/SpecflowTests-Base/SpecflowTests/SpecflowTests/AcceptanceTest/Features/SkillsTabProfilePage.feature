﻿Feature: SkillsTab_ProfilePage
In order to update my profile 
	As a skill trader
	I want to add the skills that I have done

@mytag
Scenario: Check if user could able to add a skill 
	Given I clicked on the skills tab under Profile page
	When I add a new skill
	Then that skill should be displayed on my listings

	Scenario: Check if the user gets a message to enter all details if missed any field while adding a skill
		Given I clicked on the skills tab under Profile page
		When I add a new skill by missing one field
		Then there should be a pop up "Please enter skill and experience level"

Scenario: Check if the user could able to edit a skill 
		Given I clicked on the skills tab under Profile page
		When I add a new skill
		And Try to Edit the Certification and update
		Then that new Certification should be displayed on my listings

Scenario: Check if the user could able to cancel editing a Certification
		Given I clicked on the Certifications tab under Profile page
		When I add a new Certification
		And I try to click on Edit and click on cancel button
		Then that same Certification details should be displayed on my listing

Scenario: Check if the user could able to get a message when trying to update a Certification without modifing any input
		Given I clicked on the Certifications tab under Profile page
		When I add a new Certification
		And Try not to Edit anything and click on update
		Then I should able to get an error message "This Information is already exist"

Scenario: Check if the user could able to delete a Certification
		Given I clicked on the Certifications tab under Profile page
		When I add a new Certification
		And Try to Delete the Certification
		Then that Certification should not be displayed on my listings

Scenario: Check if the user could able to cancel adding a Certification
		Given I clicked on the Certifications tab under Profile page
		When I cancel adding a new Certification
		Then that Certification should not be displayed on my listings

Scenario: Check if the user is able to get a pop up if entered same Certification details which already exist
		Given I clicked on the Certifications tab under Profile page
		When I add a new Certification
		And I add the same Certification details again
		Then I should able to get an error message "This Information is already exist"



