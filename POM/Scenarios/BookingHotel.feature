Feature: BookingHotel
Background:
Given I am on the home page
@positive
Scenario: Successful Hotel Booking
When I login and book a ticket
Then A ticket number is generated

@negative
Scenario: Unsuccessful Hotel Booking-CVV not entered
When I login and do not enter any one of the mandatory field
Then Should get an error message  




