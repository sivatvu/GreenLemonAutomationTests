Feature: ThinkMoney

	In order to verify the new software changes
	As a test user 
	I want to ensure that the tests passes as expected

Background: 

	Given I navigate to the test site
	When I enter Username, Password & Re-Type Password
	And I click on Enter
		

@Tests @PersonalDetails
Scenario: Enter your Personal Details

When I select the Title 
And I enter the First Name
And I enter the Surname 
And I enter my Date of Birth 
And I enter my Telephone Number
And I select Employment and Residential Status
And I have entered my Gross annual Income
And I enter my address
And the month and year I moved in
And I have agreed with the Terms and Conditions
And I Click on Enter on Personal Details Page
When I click on YES to set up the credit report
Then I can verify the Credit Report authentication
When I select the correct answers for the authentication questions 
And I submit the answers by pressing the Enter button
Then I am on Credit report homepage 
And I can see my Credit Score 



#When I click on YES to set up the credit report
#And I login as the test admin
#Then I can verify the credit score 
#When I click on SIGNUP button
#Then the page navigates to Create Password page


#Examples: 
#
#| FirstName | Surname    | DateofBirth | Telephonenumber |
#| Siva       | Automation | 1986-12-19    | 07411577884      |

#@Tests @SetupCreditReport
#Scenario: Set up the credit report
#
#When I click on YES to set up the credit report
#And I login as the test admin
#Then I can verify the credit score 
#When I click on SIGNUP button
#Then the page navigates to Create Password page
	
