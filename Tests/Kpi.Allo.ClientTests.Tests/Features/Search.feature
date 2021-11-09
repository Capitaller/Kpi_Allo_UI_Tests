@Search
@Regression
Feature: Search

Scenario: 1. Validate Search with Valid data
	Given I open main view
	When I search 'Apple Watch Series 6 GPS, 44mm PRODUCT(RED) Aluminium Case with PRODUCT(RED) Sport Band (M00M3)' value
	Then I see 'Смарт-годинник Apple Watch Series 6 GPS, 44mm PRODUCT(RED) Aluminium Case with PRODUCT(RED) Sport Band (M00M3)' result

Scenario: 2. Validate Search with InValid data
	Given I open main view
	When I search '999999999999999999999' value
	Then I see not found 'Нажаль, нічого не знайдено.' result