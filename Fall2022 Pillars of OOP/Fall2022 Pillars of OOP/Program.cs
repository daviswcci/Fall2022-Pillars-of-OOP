using Fall2022_Pillars_of_OOP;

Car car = new Car();
car.TopSpeed = 5000;

// Cannot create Vehicle (or any abstract class) objects, but we can use them as variables
Vehicle vehicle = new Bike();
// When in a variable of the parent class, the child only has access to the properties and methods on the parent
// meaning we can't do vehicle.Brand
// but we can do vehicle.ToStringRepresentation();
Console.WriteLine(vehicle.ToStringRepresentation());

// Polymorphism allows us to store both cars and bikes in this list of vehicles because they both inherit
// the abstract class vehicle
// Any car objects take on the form of vehicle while in the vehicle list
List<Vehicle> Vehicles = new List<Vehicle>();