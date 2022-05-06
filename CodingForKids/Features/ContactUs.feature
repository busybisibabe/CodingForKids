Feature: ContactUs
	As a user on this URL https://user-68906616-work.colibriwp.com/coding-by-k/
	I want the Contact us link to be visible on the footer  
	So I can click on it and it takes me to the contact us page

@109
Scenario Outline: Verify user enter valid details on the Contact US page
	Given user navigate to "https://user-68906616-work.colibriwp.com/coding-by-k/contact-us-1/"
	When the user enters valid full name '<fullname>' 
	And the user enters valid email '<email>'
	And the user enter valid phone number '<phoneNumber>'
	And user enters valid age  '<age>'
	And the user enter a valid message in the '<message box>'
	And the user check the captcha box
	And the user clicks on the submit button
	Then Submission is successful is displayed

	Examples: 
	| fullname       | email                     | phoneNumber | age | message box                 |
	| Oyebisi Oyekan  | allaboutu@email.com       | 07016767740  | 39  | I an new to Coding for kids |
	| Godwin Osabutey | whateveryoulike@gmail.com | 07712012281  | 120 | I am a coding guru          |
	


	Scenario Outline: Verify user enter Invalid details on the Contact US page
	Given user navigate to "https://user-68906616-work.colibriwp.com/coding-by-k/contact-us-1/"
	When the user enters valid full name '<fullname>' 
	And the user enters invalid email '<email>'
	And the user enter valid phone number '<phoneNumber>'
	And user enters valid age  '<age>'
	And the user enter a valid message in the '<message box>'
	And the user check the captcha box
	And the user clicks on the submit button
	Then form should not be submitted "One or more fields have an error. Please check and try again" should be displayed

	Examples: 
	| fullname       | email                     | phoneNumber | age | message box                 |
	| Mary Kay | itisuemail.com       | 07016767780  | 22  | When the going gets tough, only the tough gets going |
	