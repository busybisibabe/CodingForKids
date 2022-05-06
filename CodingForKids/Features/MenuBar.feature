Feature: MenuBar
	As a user on coding for kids-by-kids website 
	I want to access the the header on the landing page
	So, I can access the Menu Bar to view the contents

@1237
Scenario: Verify That Menu Bar is on the header
	Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
	When the user is on the landing page 
	Then the Menu bar should be visible and aligned to the right of the header