using System;

namespace farm
{
    class Data
    {


        static void Main(string[] args)
        {

            Plant plant1 = new Plant();
            plant1.name = "Potato";
            plant1.plantingSeason = "Spring";
            plant1.harvestingSeason = "Autumn";
            plant1.areaOccupied = 2;

            Plant plant2 = new Plant();
            plant2.name = "Strawberry";
            plant2.plantingSeason = "Spring";
            plant2.harvestingSeason = "Summer";
            plant2.areaOccupied = 2;

            Plant plant3 = new Plant();
            plant3.name = "Garlic";
            plant3.plantingSeason = "Spring";
            plant3.harvestingSeason = "Autumn";
            plant3.areaOccupied = 2;

            Plant plant4 = new Plant();
            plant4.name = "Beans";
            plant4.plantingSeason = "Spring";
            plant4.harvestingSeason = "Autumn";
            plant4.areaOccupied = 2;

            Plant plant5 = new Plant();
            plant5.name = "Tomato";
            plant5.plantingSeason = "Spring";
            plant5.harvestingSeason = "Summer";
            plant5.areaOccupied = 3;

            Plant plant6 = new Plant();
            plant6.name = "Pickle";
            plant6.plantingSeason = "Spring";
            plant6.harvestingSeason = "Summer";
            plant6.areaOccupied = 3;

            gardenBed bed1 = new gardenBed();
            bed1.numberOfPlants = 6;
            bed1.area = 20;
            bed1.listOfPlants = "Potato";

            gardenBed bed2 = new gardenBed();
            bed2.numberOfPlants = 5;
            bed2.area = 20;
            bed2.listOfPlants = "Tomato, Pickle";

            gardenBed bed3 = new gardenBed();
            bed3.numberOfPlants = 8;
            bed3.area = 20;
            bed3.listOfPlants = "Beans, Garlic";


            gardenBed bed4 = new gardenBed();
            bed4.numberOfPlants = 9;
            bed4.area = 20;
            bed4.listOfPlants = "Strawberry";

            animal animal1 = new animal();
            animal1.name = "Pig";
            animal1.product = "Meat";
            animal1.numberOfAnimals = 4;

            animal animal2 = new animal();
            animal2.name = "Cow";
            animal2.product = "Milk";
            animal2.numberOfAnimals = 1;

            animal animal3 = new animal();
            animal3.name = "Chicken";
            animal3.product = "Eggs";
            animal3.numberOfAnimals = 7;

            animal animal4 = new animal();
            animal4.name = "Goat";
            animal4.product = "Milk";
            animal4.numberOfAnimals = 3;


            building building1 = new building();
            building1.name = "Pigsty";
            building1.area = 90;
            building1.capacity = 8;
            building1.listОfАnimals = "Pig";

            building building2 = new building();
            building2.name = "Barn";
            building2.area = 110;
            building2.capacity = 4;
            building2.listОfАnimals = "Cow";


            building building3 = new building();
            building3.name = "Chicken coop";
            building3.area = 50;
            building3.capacity = 10;
            building3.listОfАnimals = "Chicken";


            building building4 = new building();
            building4.name = "Goat house";
            building4.area = 60;
            building4.capacity = 4;
            building4.listОfАnimals = "Goat";

            product product1 = new product();
            product1.name = "Meat";
            product1.weight = 200;

            product product2 = new product();
            product2.name = "Milk";
            product2.weight = 1;

            product product3 = new product();
            product3.name = "Egg";
            product3.weight = 1;


            product product4 = new product();
            product4.name = "Meat";
            product4.weight = 55;

            Farm Farm1 = new Farm();
            Farm1.name = "Godville";
            Farm1.area = 1000;
            Farm1.listOfBeds = 4;
            Farm1.listОfBuilding = 4;

            
                int a = bed1.area;
                int b = bed2.area;
                int c = bed3.area;
                int d = bed4.area;
                int sum = a + b + c + d;

            decimal Plant = bed1.numberOfPlants * plant1.areaOccupied;
            decimal Plant2 = bed2.numberOfPlants * plant5.areaOccupied;
            decimal Plant3 = bed3.numberOfPlants * plant4.areaOccupied;
            decimal Plant4 = bed4.numberOfPlants * plant2.areaOccupied;


            decimal B1 = (Plant / a) * 100;
            decimal B2 = (Plant2 / b) * 100;
            decimal B3 = (Plant3 / c) * 100;
            decimal B4 = (Plant4 / d) * 100;

            decimal A1 = (animal1.numberOfAnimals / building1.capacity) * 100;
            decimal A2 = (animal2.numberOfAnimals / building2.capacity) * 100;
            decimal A3 = (animal3.numberOfAnimals / building3.capacity) * 100;
            decimal A4 = (animal4.numberOfAnimals / building4.capacity) * 100;

            Console.WriteLine($"Report on the form:");
            Console.WriteLine($"This is a farm by name {Farm1.name}. The area of the farm is {Farm1.area}m2. There are {Farm1.listOfBeds} beds and {Farm1.listОfBuilding} buildings on the farm.");
            Console.WriteLine($"Report on beds:");
            Console.WriteLine($"The area of all beds {sum}m2");
            Console.WriteLine($"Bed number one:");
            Console.WriteLine($"Plants: {bed1.listOfPlants}. The fullness of the bed: {B1}%");
            Console.WriteLine($"Bed number two:");
            Console.WriteLine($"Plants: {bed2.listOfPlants}. The fullness of the bed: {B2}%");
            Console.WriteLine($"Bed number three:");
            Console.WriteLine($"Plants: {bed3.listOfPlants}. The fullness of the bed: {B3}%");
            Console.WriteLine($"Bed number four:");
            Console.WriteLine($"Plants: {bed4.listOfPlants}. The fullness of the bed: {B4}%");

            Console.WriteLine($"Report on building:");            
            Console.WriteLine($"Building  number one:");
            Console.WriteLine($"Аnimals: {building1.listОfАnimals}. The fullness of the building: {A1}%");
            Console.WriteLine($"Building  number two:");
            Console.WriteLine($"Аnimals: {building2.listОfАnimals}. The fullness of the building: {A2}%");
            Console.WriteLine($"Building  number three:");
            Console.WriteLine($"Plants: {building3.listОfАnimals}. The fullness of the building: {A3}%");
            Console.WriteLine($"Building  number four:");
            Console.WriteLine($"Аnimals: {building4.listОfАnimals}. The fullness of the building: {A4}%");

        }
    }

}

