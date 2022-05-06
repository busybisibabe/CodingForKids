Feature: HomePageBody
	

@482
Scenario: Verify that the three components of the body are Picture Slide Show, Teaching Philosophy and Testimonials and Awards
	Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
	When the user is on the landing page
	Then Picture Slide Show, Teaching Philosophy and Testimonial Awards should be on the main body