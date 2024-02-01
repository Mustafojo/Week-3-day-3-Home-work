var train = new Train();
train.Name = "TOJ";
train.Model = "Soyuz";
train.Color = "White";
train.Speed = 120;
train.Passenger = 238;
train.Year = 2021;
System.Console.WriteLine(train.ToString());
System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");


var pasCar = new PassengerCar();
pasCar.Name = "BMW";
pasCar.Year = 2023;
pasCar.Color = "Black";
pasCar.Door = 4;
pasCar.Model = "M5F90";
pasCar.Speed = 330;
pasCar.Passenger = 5;
System.Console.WriteLine(pasCar.ToString());
System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");



var cargoCar = new CargoCar();
cargoCar.Name = "Volvo";
cargoCar.Year = 2023;
cargoCar.Passenger = 3;
cargoCar.Color = "Black";
cargoCar.Door = 2;
cargoCar.Model = "Nav";
cargoCar.Speed = 280;
cargoCar.Weight = 7;
System.Console.WriteLine(cargoCar.ToString());
System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");


var pasPlane = new PassengerPlane();
pasPlane.Name = "Emirates";
pasPlane.Year = 2020;
pasPlane.Color = "White";
pasPlane.Country = "Dubay";
pasPlane.Model = "A747";
pasPlane.Passenger = 320;
pasPlane.Speed = 920;
System.Console.WriteLine(pasPlane.ToString());
System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");



var cargoPlane = new CargoPlane();
cargoPlane.Name = "Somon-Air";
cargoPlane.Year = 2012;
cargoPlane.Color = "White";
cargoPlane.Country = "Tajikistan";
cargoPlane.Model = "A47";
cargoPlane.Bor = 4300;
cargoPlane.Speed = 730;
System.Console.WriteLine(cargoPlane.ToString());
System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");


