using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
RandomizeAnimals();
//AssignGroup();
//PrintGroup(group);
Console.WriteLine("School A");
//string[,] group = AssignGroup();

void RandomizeAnimals() {
    Random rand = new();
    for(int i = 0; i < pettingZoo.Length; i++) {
        int r = rand.Next(i, pettingZoo.Length);
        string t = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = t;
    }
}