# Bees by Robyn Smillie

-- Why I decided to use Win Forms. -- 

I decided on Win Forms because I do not have good enough experience
with any other C# front-end dev tools like Xamarin to build a UI in an hour. Win Forms is also very
easy to use and good enough for building basic UIs in a short amount of time. 

-- How I decided to build the application. -- 

I decided to start with the base classes. From the description it seemed that the best
option was to create a superclass for bee and inherit the bee characteristics such as
health, alive or dead etc for the worker, drone and queen classes.

The BeeOperations class was built next which includes other methods which can performed. 

Then upon the damage btn click for each bee in the list, a random number will be generated
and the health updated after calculating the damage. 

I admit I did not follow TDD and created the unit tests last. Hopefully learning how to
implement TDD properly is a skill I could learn here!

Lastly I decided to test the max and max+1 boundaries of minHealth after damage for each type of bee.

Due to lack of time, there are numbers in the code where constants could have been 
used instead, missing test casess and commenting has not been completed.



