using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Constructors
{
    public class Multicooker
    {
        public string Model { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int ProductWeight { get; set; }
        public int Wattage { get; set; }
        public double Capacity { get; set; }
        public int Functions { get; set; }
        private string EngineModel;
        private string ControlBoardModel;

        public Multicooker() : this("Default Model", DateTime.Now)
        {
            //Model = "Default Model";
            //ManufacturingDate = DateTime.Now;
            //ProductWeight = 0;
            //Wattage = 0;
            //Capacity = 0.0;
            //Functions = 0; 
            Console.WriteLine("Hello ctor # 1");
        }
        public Multicooker(string model, DateTime manufacturingDate) : this(model, manufacturingDate, 0, 0)
        {
            //Model = "Default Model";
            //ManufacturingDate = DateTime.Now;
            Console.WriteLine("Hello ctor # 2");
        }
        public Multicooker(string model, DateTime? manufacturingDate = null,  int? productWeight = null, int? wattage = null, double capacity = 0.0, int functions = 0)
        {
            Model = model;
            ManufacturingDate = manufacturingDate ?? DateTime.Now;
            ProductWeight = productWeight ?? 0;
            Wattage = wattage ?? 0;
            Capacity = capacity;
            Functions = functions;
            Console.WriteLine("Hello ctor # 3"); 
        }

        public void StartCooking()
        {
            Console.WriteLine("Let`s start cooking");
            CookFood();
        }
        private void CookFood()
        {
            Console.WriteLine("Cooking is in process");
        }

        public string SubmitForRepair(int faultCode)
        {
            Console.WriteLine("The multicooker is handed over for repair with a breakdown code: " + faultCode);
            //return EstimateRepairCost(faultCode);

            decimal repairCost = EstimateRepairCost(faultCode);
            string formattedCost = $"{repairCost:C} USD";
            Console.WriteLine("Estimated repair cost: " + formattedCost);

            return formattedCost;
        }

        private decimal EstimateRepairCost(int faultCode)
        {
            decimal defaultCost = 0;

            switch (faultCode)
            {
                case 1:
                    defaultCost = 100;
                    break;
                case 2:
                    defaultCost = 200;
                    break;
                case 3:
                    defaultCost = 300;
                    break;
                default:
                    // Handle any unknown fault codes here, for example:
                    defaultCost = 0; // Unknown fault code has a cost of 0
                    break;
            }

            return defaultCost;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Info about the multicooker:");
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Manufacturing Date: " + ManufacturingDate);
            Console.WriteLine("Product Weight: " + ProductWeight + " grams");
            Console.WriteLine(" Wattage: " + Wattage + " W");
            Console.WriteLine("Capacity: " + Capacity + " litres");
            Console.WriteLine("Functions: " + Functions);
        }
    }
}
