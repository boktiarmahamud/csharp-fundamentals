using OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class DeliveryService
    {
        // Based on distance
        public double CalculateDeliveryFee(double distance)
        {
            return distance * 20; 
        }

        // Based on weight
        public double CalculateDeliveryFee(double distance, double weight)
        {
            return (distance * 20) + (weight * 10);
        }

        // Based on priority
        public double CalculateDeliveryFee(double distance, double weight, bool isPriority)
        {
            double fee = (distance * 20) + (weight * 10);
            if (isPriority)
            {
                fee += 50; 
            }
            return fee;
        }
    }
    internal class CompileTimePolymorphism
    {

        public static void Main(string[] args)
        {
            DeliveryService deliveryService = new DeliveryService();

            // Calculate delivery fee based on distance
            double fee1 = deliveryService.CalculateDeliveryFee(10);
            Console.WriteLine($"Delivery fee based on distance: {fee1}");

            // Calculate delivery fee based on distance and weight
            double fee2 = deliveryService.CalculateDeliveryFee(10, 5);
            Console.WriteLine($"Delivery fee based on distance and weight: {fee2}");

            // Calculate delivery fee based on distance, weight, and priority
            double fee3 = deliveryService.CalculateDeliveryFee(10, 5, true);
            Console.WriteLine($"Delivery fee based on distance, weight, and priority: {fee3}");

        }
    }
    
}
// ---Problem Statement---
//a restaurant calculates the delivery charge differently depending on the information provided:
//Calculate delivery charge using distance
//Calculate using distance +order weight
//Calculate using distance +order weight + priority