This is a simple console-based number guessing game developed as a homework assignment. The program randomly generates 10 unique numbers between 1 and 99. Then the user is asked to input 10 unique numbers within the same range.

After all numbers are entered, the program compares user's numbers with the generated ones and calculates how many numbers are matching. One match earns a point. Also user gets a message depending on earned points.


I am using a for loop to store the right amount of both - generated and input values into the List<int> collections.
To ensure that the input is a number, in a correct range and unique, input validation is implemented using if conditions. Only valid entries are added to lists.
I am using a foreach loop to find matching numbers and add the color. I assign messages to different amounts of earned points using if else statement.

I tried to structure the code to be as clean and logical as possible.

