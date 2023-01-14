using DieRoller;

Die myDie = new Die(); //when die is created a random facevalue should be set
Console.WriteLine(myDie.FaceValue);
myDie.Roll();

Console.WriteLine(myDie.FaceValue);
myDie.Roll();

Console.WriteLine(myDie.FaceValue);
myDie.Roll();

myDie.IsHeld = true;
Console.WriteLine("holding the die");

Console.ReadKey();
