Feature: HomepageProductInfo
	As a registered user
	I want to be able to login
	I want to view products on my homepage

@mytag
Scenario: Homepage Product Information
	Given I navigate to giftrete website
	When I click on login
	And I enter my email address
	And I enter my password
	And I click signin
	And I click the hometab
	And I click free items
	And I click wishlist
	And I click community
	Then I have information about the products

Scenario: Homepage Banner
	Given I navigate to giftrete website
	When I click on login
	And I enter my email address
	And I enter my password
	And I click signin
	And I click the hometab
	And I click Giftretecycle Banner
	And I click community banner
	And I click wishlist banner
	Then I can easily choose what to browse

Scenario: Homepage Information
	Given I navigate to giftrete website
	When I click on login
	And I enter my email address
	And I enter my password
	And I click signin
	And I click the hometab
	And I click learn more about Giftrete
	Then I understand what the website is all about