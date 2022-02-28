// See https://aka.ms/new-console-template for more information
using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.AbstractFactory.ConcreteFactories;

//Make Client instance
Client c = new Client();

//Get products using specific factories as parameters
c.GetNewFurniture(new ModernFurnitureFactory());
c.GetNewFurniture(new VictorianFurnitureFactory());


