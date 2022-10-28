# JohnsonRRestaurantPickerEndpoint

Richard Johnson
10-27-22

HOW TO USE: Open the project in VSCode and click "Run and Debug." After you've clicked this, the program will run and open the API in your web browser with a URL starting with "localhost." When it does, go into the debug console and look through the section of white text to find a different URL with "http" instead of "https", so you can copy and paste that into an API platform such as Postman. After pasting it, edit the URL to add "/RestaurantPicker/restaurant/fastfood" if you want to pick a Fast Food restaurant, or "/RestaurantPicker/restaurant/chinese" if you want a Chinese Takeout Restaurant, or "/RestaurantPicker/restaurant/italian" for an Italian restaurant. Whichever of the three you enter, the API will return a randomly generated string of text with the name of a restaurant fitting the category you entered in the URL. If you enter the url more than once, the API will return a different restaurant name.

Peer review: Rafael Manzo  confirmed on code running, runs well would say use 1 2 3 as cases perhaps