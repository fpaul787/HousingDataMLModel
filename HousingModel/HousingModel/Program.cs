using HousingModelML.Model;
using System;

namespace HousingModel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            var input = new ModelInput();
            input.Longitude = -122.25F;
            input.Latitude = 37.83F;
            input.Housing_median_age = 52;
            input.Total_rooms = 1688;
            input.Total_bedrooms = 300;
            input.Population = 150;
            input.Households = 150;
            input.Median_income = 2.125F;
            input.Median_house_value = 191300;
            input.Ocean_proximity = "NEAR BAY";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Prediction: {result.Score}");
        }
    }
}

