This is a simple console-based number guessing game developed as a homework assignment. The program randomly generates 10 unique numbers between 1 and 99. Then the user is asked to input 10 unique numbers within the same range.

After all numbers are entered, the program compares user's numbers with the generated ones and calculates how many numbers are matching. One match earns a point. Also user gets a message depending on earned points.


A FOR loop is being used to store the right amount of both - generated and input values into the List<int> collections.
To ensure that the input is a number, in a correct range and unique, input validation is implemented using IF conditions. Only valid entries are added to lists.
A FOREACH loop is being used to find matching numbers and adding the color for user's convenience. The program uses IF-ELSE statements to show messages according to the player's score.

This game was developed to practice loops, conditional statements, and input validation.

