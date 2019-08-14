Feature: BbcQuestionForm
	In order to test BBC question form
	As a BBC site user
	I want to submit message

@mytag
Scenario Outline: Open question form and fill all fields with required string
	Given User generates text with length <inputTextLength> symbols
	When User navigates to question form on BBC, enter generated text and fill other fields with following details
		| name         | age | email        | postalCode |
		| Mary J Blige | 34  | email@com.us | 02092      |
	Then User takes screenshot

	Examples:
		| inputTextLength |
		| 141             |
		| 140             |

Scenario Outline: Open question form and fill question form on BBC without email
	Given User generates text with length 140 symbols
	When User navigates to question form on BBC, enter generated text and fill other fields with following details
		| name   | age   | email   | postalCode   |
		| <name> | <age> | <email> | <postalCode> |
	And User presses submit button
	Then User sees error '<error>' for '<field>' field

	Examples:
		| name         | age | email        | postalCode | error                        | field |
		| Mary J Blige | 34  |              | 02092      | Email address can't be blank | email |
		|              | 34  | email@com.us | 02092      | Name can't be blank          | name  |