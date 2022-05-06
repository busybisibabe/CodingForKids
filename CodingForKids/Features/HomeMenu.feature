Feature: HomeMenu
	As a user on coding for kids-by-kids website i.e. https://user-68906616-work.colibriwp.com/coding-by-k/
I want to access the home menu on the header 
So, I can access the landing page from any page of the website

@regression
Scenario: Verify that the Home Menu is visible on the header
	
	Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
	When the user is on the landing page
	Then the Home menu is visible on the header for the user to navigate 