var smartPhone = new SmartPhone(128,64,"USA",800,0);
smartPhone.Selfies();
smartPhone.Selfies();
smartPhone.Selfies();
smartPhone.Selfies();
System.Console.WriteLine("----------------------------------------------------------");
System.Console.WriteLine(smartPhone.GetFullInfo());
System.Console.WriteLine("----------------------------------------------------------");
smartPhone.WeightCheck();
System.Console.WriteLine("----------------------------------------------------------");

var laptop = new Laptop(512,128,"RUS",2);
System.Console.WriteLine(laptop.GetFullInfo());
System.Console.WriteLine("----------------------------------------------------------");
laptop.WeightCheck();
System.Console.WriteLine("----------------------------------------------------------");

