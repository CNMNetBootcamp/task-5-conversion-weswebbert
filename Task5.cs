 int volume; //number
 int convertedUnit
 string question;
 string CurrentUnit; // Cups, Quarts, Gallons
           
 //input
 PUT "What is the volume?"
 GET volume
 
 PUT "Is this cups or quarts"
 GET unit
 
 //processing
 if (CurrentUnit == "Cups")
	convertedUnit = volume / 4;
	Console.WriteLine("The value " + volume + " cups " + "converted to quarts is " + convertedUnit + " quarts");

 if (CurrentUnit == "cups")
     convertedUnit = volume / 16;
     Console.WriteLine("The value " + volume + " cups " + "converted to gallons is " + convertedUnit + " gallons");
            
 if (CurrentUnit == "quarts")
     convertedUnit = volume * 4;
     Console.WriteLine("The value " + volume + " quarts " + "converted to cups is " + convertedUnit + " cups");
            
 if(CurrentUnit == "quarts")
    convertedUnit = volume / 4;
    Console.WriteLine("The value " + volume + " quarts " + "converted to gallons is " + convertedUnit + " gallons");
            
 if (CurrentUnit == "gallons")
     convertedUnit = volume * 16;
     Console.WriteLine("The value " + volume + " gallons " + "converted to cups is " + convertedUnit + " cups");
            
 if (CurrentUnit == "gallons")
     convertedUnit = volume * 4;
     Console.WriteLine("The value " + volume + " gallons " + "converted to quarts is " + convertedUnit + " qaurts");
            

     Console.ReadLine();	
	 
//output
PUT textType
	