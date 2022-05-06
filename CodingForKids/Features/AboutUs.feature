Feature: AboutUs
	As a user on https://user-68906616-work.colibriwp.com/coding-by-k/
	I want the about us link to be visible on the footer 
	So I can click on it and it redirects me to the about us page

@178
Scenario: Verify that About Us link redirects user
	Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
	When the user is on the landing page
	And the user clicks on the About Us link on the footer  
	Then the user should be redirected to the about us page