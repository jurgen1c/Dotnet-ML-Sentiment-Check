//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleClassification.Model;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                SentimentText = @"==RUDE== Dude, you are rude upload that carl picture back, or else.",
                LoggedIn = true,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Sentiment with predicted Sentiment from sample data...\n\n");
            Console.WriteLine($"SentimentText: {sampleData.SentimentText}");
            Console.WriteLine($"LoggedIn: {sampleData.LoggedIn}");
            Console.WriteLine($"\n\nPredicted Sentiment value {predictionResult.Prediction} \nPredicted Sentiment scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
