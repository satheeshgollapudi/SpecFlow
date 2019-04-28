Feature: CertificateTab_ProfilePage
In order to update my profile 
	As a skill trader
	I want to add the Certifications that I have done

@mytag
Scenario: Check if user could able to add a Certification 
	Given I clicked on the Certifications tab under Profile page
	When I add a new Certification
	Then that Certifcation should be displayed on my listings

