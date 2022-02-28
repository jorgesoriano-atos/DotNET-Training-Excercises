using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.AbstractFactory.AbstractProducts;
using AbstractFactoryExample.AbstractFactory.ConcreteFactories;

namespace AbstractFactoryExample.AbstractFactory
{
    public class Client
    {
        public Client()
        {

        }

        //Use anonymous variables to store the product A and B instances, in this way variables are decoupled to the actual types
        public void GetNewFurniture(IAbstractFurnitureFactory furnitureFactory)
        {
            var newChair = furnitureFactory.MakeChair();
            var newTable = furnitureFactory.MakeTable();

            Console.WriteLine($"testing new furniture: \n\t" +
                $"We got... A {newChair.GetStyle()} chair, {newChair.HasLegs()}, {newChair.SitOn()}\n\t" +
                $"Aaannd... A {newTable.GetStyle()} table, {newTable.HasLegs()}, {newTable.DineOn()}.");
        }


    }
}
