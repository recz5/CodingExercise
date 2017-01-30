# CodingExercise
A standard deck of 52 playing cards that can be shuffled and sorted.

### The Exercise

1.	Write a method, function, or procedure that sorts a standard deck of 52 playing cards in ascending order.
    
2.	Write a method, function, or procedure that randomly shuffles a standard deck of 52 playing cards.


### About the problems

* Complete the exercises using C#, JavaScript, or T-SQL.

* You should presume this code will be used in a variety of games that all use a standard deck of 52 playing cards (four suits of thirteen cards each). Given this purpose, create whatever types, modules, and structures you feel are necessary to complete the exercises.

* In all cases, write automated tests for your work. Use whatever testing framework you prefer. Structure the tests as you see fit. Write as many tests as you feel are necessary and sufficient to build "shippable", customer-ready confidence in your code. You may use TDD or BDD if you prefer, but it's not required. The testing approach, technique, and technology are entirely up to you, but you should be ready to explain and advocate for your approach. It should go without saying that all your automated tests should pass. :)

* Write code to suit yourself. Please don’t try to guess what we "really want": We just want to see your code!  Show us how you prefer to work. Show us code you’re proud of. Keep it as simple as you’d like; or, if you prefer, show us a really sophisticated algorithm. The choice is yours!

#### About The Technology

We must be able to read and run your results. To that end:

* Do not reference any code or libraries that require a paid license or subscription.

* Do not use any frameworks or libraries that aren't available for use by the general public.

* Do not use code or libraries that are protected by copyright, intellectual property rights, or any other restriction that prevents free sharing and use of the code or libraries.

All work will be evaluated on a computer running Windows 7 or Windows 10.

## The Solution

The MVP solution contains 3 projects using C#.Net, Visual Studio, Microsoft Unit Test Framework, C# Console Application, Git...

    1. PlayingCards DLL
       * Module for creating a standard deck
       * Contains objects that represent Cards, Deck of cards, Dealer, shuffle and sort
       * Maintainability 93
       * Complexity 42 (methods are below 10)
       * Coupling 18 (high coupling on StandardDeck)
       * Depth of Inheritance 1
       * 100% Test Coverage

    2. PlayingCardsApplication
       * Simple user interface that demonstrate a standard deck of playing cards
       * Maintainability 69 (needs review/refactoring/redesign)
       * Complexity 17 (methods are below 10)
       * Coupling 12 (would need to review/redesign)
       * Depth of Inheritance 1

    3. TestPlayingCards
       * Unit test for PlayingCards DLL
       * Maintainability 65 (needs review/refactoring/redesign)

    4. TestPlayingCards_xUnit
       * Unit test for PlayingCards DLL
       * using xUnit Framework
       * Added for GitHub Travis Continuous Integration since there is no open source support for Visual Studio UnitTest framework is not supported 

#### How to use and contribute

    * To contribute - you'll need Git, an IDE for compiling C#.Net and Windows environment
    * To test code only - you'll an IDE for compiling C#.Net and Windows environment
    * To use released MVP version - you'll Windows environment

#### Contributing

    * Clone repo
    * Create new local branch
    * Publish local branch
    * Pass Travis CI
    * Create pull request

#### Branches

    * master - current released version (running MVP_xUnit_DotNet4.5)
    * MVP - dotNet 4.5 version, Microsoft UnitTest framework
        * TestPlayingCards not compiled because Travis CI. Enable compilation if running in Visual Studio
    * MVP_xUnit_DotNet4.5 - dotNet 4.5 version, xUnit framework v2
        * TestPlayingCards not compiled because Travis CI. Enable compilation if running in Visual Studio
    * mvp_xunit_framework - dotNet 4.0, xUnit framework v1
        * TestPlayingCards not included.

