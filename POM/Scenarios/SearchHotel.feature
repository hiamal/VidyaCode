Feature: SearchHotel

Scenario Outline: Select a location
Given I login into the website
When I select a <location> and <Date>
Then the <location> is selected

Examples:
| location | Date       |
| London   | 22/02/2019 |
| Sydney   | 24/09/2019 |
| Delhi    | 24/07/2019 |