Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
	
	
	
	Scenario Outline: I can define type
	Given taxomoy has type for Items
	When type is asked for an Item with <itemId>
	Then <type> is returned

	Examples: 
	| itemId | type |
	| 21     | 0    |
	| 22     | 1    |
	| 23     | 0    |
	| 24     | 1    |
