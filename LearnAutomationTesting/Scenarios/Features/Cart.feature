Feature: Cart
Scenario: Add an item to cart
Given I opened my home page and click the loginlink
And Enter email address and password and click sign in
Then search for the product and select the product
And add the item to cart and check whether item is in cart

Scenario: Cannot add item to cart
Given I opened my home page and click the loginlink
And Enter email address and password and click sign in
Then search for the product and select the product
And add the item to cart with no quantity and check whether item is added to cart

Scenario: View an item added to cart
Given I opened my home page and click the loginlink
And Enter email address and password and click sign in
Then search for the product and select the product
And add the item to cart and check whether item is in cart
And view the item added to cart and check whether item is in cart

Scenario: Increase the quantity of the item added to cart
Given I am on the home page
When I login and add an item to cart
Then view the item in cart and increase the quantity
And cart needs to be updated with new quantity for the item



