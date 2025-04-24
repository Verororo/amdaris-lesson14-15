using System;
using System.Collections.Generic;

// Builder pattern

var barista = new Barista();
BeverageBuilder builder = new CappucinoBuilder();
var sugar = new Sugar();
Beverage cappucino = barista.Make(builder, sugar, sugar);

Console.WriteLine(cappucino.GetDescription());


//var db = Database.GetInstance();

//class Database
//{
//    private static Database instance;
//    private Database() { }
//    private static object obj = new Object();

//    public static Database GetInstance()
//    {
//        if (instance == null)
//        {
//            lock (obj)
//            {
//                if (instance == null) 
//                { 
//                    instance = new Database(); 
//                }
//            }
//        }
//        return instance;
//    }
//}