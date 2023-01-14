using DieRoller;

Die myDie = new Die(); //when die is created a random facevalue should be set
myDie.FaceValue = 6; //setting face value should not be allowed outside of the class

myDie.Roll();
myDie.Roll();
myDie.Roll();

Console.ReadKey();
