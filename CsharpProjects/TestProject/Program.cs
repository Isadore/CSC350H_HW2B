string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
RandomizeAnimals();
Console.WriteLine("School A");
string[,] group = AssignGroup();
PrintGroup(group);

void RandomizeAnimals() {
    Random rand = new();
    for(int i = 0; i < pettingZoo.Length; i++) {
        int r = rand.Next(i, pettingZoo.Length);
        string t = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = t;
    }
}

string[,] AssignGroup(int groups = 6) {
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;
    for(int i = 0; i < groups; i++) {
        for(int j = 0; j<result.GetLength(1); j++) {
            result[i,j] = pettingZoo[start++];
        }
    }
    return result;
}

void PrintGroup(string[,] group) {
    for(int i = 0; i < group.GetLength(0); i++) {
        for(int j = 0; j < group.GetLength(1); j++) {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }
}