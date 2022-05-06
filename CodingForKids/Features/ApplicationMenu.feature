Feature: ApplicationMenu
As a user on coding for kids-by-kids website i.e. https://user-68906616-work.colibriwp.com/coding-by-k/
I want the "coding for kids by kids " Application menu to be visible on the header 
and last on the right-side of the menu bar
So I can identify the Application menu to be able to apply for the courses

@mytag
Scenario:  Verify that Application menu is visible on the rightside of the menu bar
Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
When the user is on the landing page 
Then the coding for kids by kids Application menu should be visible and last on the rightside of the menu bar