\******************************************************************
 ********************* Search and Go README! **********************
 ******************************************************************\

\******************************************************************
 * Prepared By: Alaa Azazi, Gellert Kispal and Sydney Pratte 
 * Contents: 
 *			1. System Features
 *			2. System Overview			
 *			3. Detailed Walk-through
 ******************************************************************\
 
 \*************************
  **** System Features ****
  *************************\  
This section outlines the main features that were implemented in the vertical prototype. These features flow directly from the list of prioritized requirements developed in the early stages of the project. A list of the implemented features is found below. 
	1. User can search for an item
	2. User can view product information
	3. User can browse items 
	4. User can browse categories
	5. User can check the availability of items at multiple locations
	6. User can view item section location on a map of the store
	7. Users can request assistance from an employee
	8. System displays current promotions
		
 \*************************
  **** System Overview ****
  *************************\  
Use this part of the document as a guide to navigate the system.
This application consists of a few screens: Initial screen, Main screen and Item screen.

	1. Initial Screen
	The initial screen's purpose is to notify the users of the system that this is a touch based application and since a mouse is not provided. It is the only way the application receives input other than the keyboard.

	2. Main Screen
	The main page of the application has the following objects: search bar, home (Sport check) button, language button, help button, advertisement section, and browse/results section. Below is an explanation on what each button and sections role is.

		2.1 Home (Sport Chek) Button
		This button resets the application to the default (initial) view. Search results will be discarded and browsing section will be restored to list all categories.

		2.2 Search Bar
		This element provides the search functionality. All one need to do is type a desired item, category or any other keyword into the box and search result will be displayed once go button on the right is pressed or enter key is hit.

		2.3 Language Button
		This button allows the user to switch in between English and French (not actually implemented due to the scope of the course).

		2.4 Help Button
		Provides the user with the readme file and calls customer service representative for help if needed.

		2.5 Advertisement Section
		This section has adds rotating on their own in order to inform the user about the current deals going on in the store. The user can click on one add which will cause the system to display the items that are advertised on the banner. The user can also navigate through the different ads by pressing the arrow keys on the side and also be clicking the radio buttons on the bottom of the advertisement.

		2.6 Browse/Results Section
		This section resides on the lower half of the screen. It is actually used for both display search results and browsing. Searching and browsing are similar actions, both involve displaying filtered result. The difference is when browsing the only filter one changes is the category, whereas when searching the filter is whatever keyword is input in the search box. Thus both results are displayed in one section.

	3. Item Screen
	This screen consists of several buttons and sections. All of them are self-explanatory; size drop down menu is used to pick the size of the item, the color drop down menu is used to choose the color etc.
	
 \*************************
  * Detailed Walk-through *
  *************************\
 This section of the document provides a detailed walk-through that goes through the main features of the vertical prototype. More information regarding the individual elements of the system can be found in the previous section. 
	
	1. Navigate to the SearchAndGo directory within the CPSC-481 directory
	2. Open the project solution file "SearchAndGo.sln" 
	3. Run the project in debug mode from Visual Studio
	4. When presented with the welcome screen, click the "touch to START" button
	5. When presented with the main screen: 
		5.1 Click on the "FOOTWEAR" category picture to the lower right corner of the screen to browse items within this category
		5.2 When presented with available items in the category, click on the picture of the first item - from the left, in the list
		5.3 When presented with the item screen, click the "Find in this store" button to locate this item within the store
		5.4 To close the "find in store" screen, click the close button to the top right corner of the window
		5.5 When presented with the item screen, click the "See other locations" button to check this item in other stores
		5.6 Click the "Southcenter Mall: In Stock" button to view a map to the store in that location
		5.7 To close the "See other locations" screen, click the close button to the top right corner of the window
		5.8 To close the "item" screen, click the close button to the top right corner of the window
	6. Click the SportChek logo button to the upper left corner of the screen to navigate back to the main screen
	7. When presented with the main screen, 
		7.1 Click on the left and/or the right arrow buttons to the left and right of the advertisement banner to navigate through special offers
		7.2 To search the store, click in the search bar, type in "blue" and press enter
		7.3 When presented with the search results screen, follow steps 5.2 - 5.8 to test the previous features with these items
		7.4 Click the SportChek logo button to the upper left corner of the screen to navigate back to the main screen
	8. When presented with the main screen,
		8.1 Click on the help button to the upper right corner of the screen to show the help screen
		8.2 When presented with the help screen, click on the "Request a customer service representative's help" button to request a representative
		8.3 When presented with the confirmation screen, click the close button to the upper right corner of the screen to close the help screen
		