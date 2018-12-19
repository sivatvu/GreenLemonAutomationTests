Feature: ThinkMoney

	In order to verify the new software changes
	As a test user 
	I want to ensure that the tests passes as expected

Background: 

	Given I navigate to the test site
	Then I am on Create Account page
	When I enter Username, Password & Re-Type Password
	And I click on Enter
	Then I can enter my personal details

@Tests @PersonalDetails
Scenario Outline: Enter your Personal Details and Verify the Credit Score

    When I select the Title 
    And I enter the following values into the Personal Details page "<FirstName>", "<SurName>", "<DateofBirth>", "<TelephoneNumber>" and "<GrossAnnualIncome>"
    And I select Employment and Residential Status
    And I enter my address
    And the month and year I moved in
    And I have agreed with the Terms and Conditions
    And I Click on Enter on Personal Details Page
    Then I can successfully enter my personal details
#Credit Report
    When I click on YES to set up the credit report
    Then I can verify the Credit Report authentication
    When I select the correct answers for the authentication questions 
    And I submit the answers by pressing the Enter button
    Then I am on Credit report homepage 
    And I can see my Credit Score 

Examples:

| FirstName  | SurName    | DateofBirth | TelephoneNumber | GrossAnnualIncome |
| GreenLemon | Automation | 1987-10-10  | 01273006033     | 200000            |
