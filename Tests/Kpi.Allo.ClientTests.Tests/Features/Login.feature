@Login
@Smoke
@Regression
Feature: Login

Scenario: 1. Verify Registered Login
	Given I have 'ExistingUser' user
	And I set login
	And I set password
	When I login to app
	Then I see 'IT-92' user

Scenario Outline: 2. Verify invalid Login
	Given I have <User> user
	And I set login
	And I set password
	When I login to app
	Then I see invalid <Result> user

	Examples:
		| User                              | Result                                                                                                                              |
		| 'NoExistingUser'                  | 'Користувач з email Invalid@gmail.com не зареєстрований. Будь ласка, зареєструйтесь чи авторизуйтесь за допомогою номеру телефона.' |
		| 'ExistingUserWithInvalidPassword' | 'Невірна адреса електронної пошти (email) або пароль.'                                                                              |