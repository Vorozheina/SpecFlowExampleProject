Feature: StringModifier
	In order to avoid silly mistakes
	As a silly text editor
	I want to be told the adding of the second string in the ending of the first string

@mytag
Scenario: Add the second string in the ending of the first string
	Given I have entered "abc" into my string modifier
	And I have also entered "def" into my string modifier
	When I press add the second string in the ending of the first string 
	Then the result should be "abcdef" on the screen
