Feature: CancelBooking
@positive
Scenario: Successful cancellation of Booking
Given I am on the home page of another build version
When I login and cancel the booking
Then Booking cancelled successfully

@negative
Scenario: Cancellation not successful
Given I am on the home page of another build version
When I login and do not select the order to cancel
Then cancellation is not successful
