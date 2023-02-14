// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Enter 1 to display full triangle, 2 to display a partial triangle, and 3 to exit.");
int option = int.Parse(Console.ReadLine());
while (option != 3){
    switch (option){
        case 1:
        GetFull();
        break;

        case 2:
        GetPartial();
        break;

        default:
        DisplayInvalid();
        break;
    }
    option = int.Parse(Console.ReadLine());
}


static void DisplayInvalid(){
    Console.WriteLine("Invalid. Try Again");
}
static void GetFull(){
    Random rnd = new Random();
    int row = rnd.Next(3,10);

    for (int i = 0; i <= row; i++){
        for (int j = 0; j <= i; j++){
            Console.Write("o");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Enter 1 to display full triangle, 2 to display a partial triangle, and 3 to exit.");
}
static void GetPartial(){
    int row = GetRandom(3,10);

    for (int i = 0; i <= row; i++){
        for (int j = 0; j <= i; j++){
            if (j == GetRandom(0,10)) Console.Write(" ");
            else Console.Write("o");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Enter 1 to display full triangle, 2 to display a partial triangle, and 3 to exit.");  

    int GetRandom(int x, int y){
    Random rnd = new Random(); 
    int random = rnd.Next(x,y);
    return random;
}
}