# Project 1 - The Barista
For the procedures used in this project see : [Procedures](Procedures.md)

In this projects should you create an Fluent API for a [barista](https://en.wikipedia.org/wiki/Barista) to create espresso based drinks using code. To get into the Barista domain have a look at [The Ultimate Beginner's Guide to Espresso](https://prima-coffee.com/learn/section/espresso) they also have a [A Beginner's Guide to Espresso](https://www.youtube.com/watch?v=-kd-zX-JOVU) video-series (5 parts).

Remember that a great barista is also keen on which [kind of beans](https://club.atlascoffeeclub.com/4-main-types-of-coffee-beans/) you are using in your beverage, so maybe its good to consider how to control the beans in your drink and how it will maybe affect price or taste.

# Espresso Machine API
You are the developer of the API for a new Espresso Machine from (the fictive company) Espressab, you are to create an API which makes it easy for C# programmers to create six different types of espresso:

![Six coffee types](https://www.latteartguide.com/wp-content/uploads/2016/01/different-types-of-coffee-infograph.jpg)

The final method of the API should return a beverage-object of the correct type, depending on the methods which have been executed. If the produces beverage does not match one of the given types, should a seventh type *Custom beverage* be the output. 

An example of how the API could look (this is pseudo-code!!):

```c#
CoffeeBeverage espresso = new EspressoMachine()
                            .AddWater(20)
                            .AddBeans(new Bean(){ 
                                AmountInG = 5,
                                Sort = CoffeSorts.Robusta})
    						.Validate(e => e.Temerature > 90)
                        .ToBeverage();
// espresso is type of Espresso

CoffeeBeverage latte = new EspressoMachine()
                            .AddBeans(new Bean(){ 
                                AmountInG = 5,
                                Sort = CoffeSorts.Robusta})
                            .GrindBeans()
                            .AddWater(20)
                            .AddMilk()
       						.Validate(e => e.Temerature < 80)
                        .ToBeverage();
// latte is type of Latte
```

See the Beverage in code project : [BaristaApi/Beverage.cs](BaristaApi/Beverage.cs)

## The solution 

The solution should cover the following:

- Encapsulation, Inheritance, Polymorphism, Abstraction
- **Unit tests**, is a must that the solution contains some unit tests
- A fluent API, which uses some lambda expressions

Extra

- Attributes
- Reflection

