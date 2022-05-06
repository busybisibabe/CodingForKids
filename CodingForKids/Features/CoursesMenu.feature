Feature: CourseMenu
As a user on coding for kids-by-kids website i.e. https://user-68906616-work.colibriwp.com/coding-by-k/
I want the Courses menu to be visible on the menu bar 
So I can click on it to access the courses available on the website	

@regression
Scenario: Verify that Courses Menu is visible at the middle of the menu bar
Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
When the user is on the landing page
Then the coding for kids by kids courses menu is visible at the middle of the menu bar
