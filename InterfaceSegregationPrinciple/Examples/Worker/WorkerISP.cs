﻿namespace InterfaceSegregationPrinciple.Examples.Worker
{
    public interface IBaseWorker
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }


    }

    public interface IFullTimeWorkerSalary : IBaseWorker
    {
        float MonthlySalary { get; set; }
        float OtherBenefits { get; set; }
        float CalculateNetSalary();
    }

    public interface IContractWorkerSalary : IBaseWorker
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalculateWorkedSalary();
    }

    public class FullTimeEmployeeFixed : IFullTimeWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float MonthlySalary { get; set; }
        public float OtherBenefits { get; set; }
        public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
    }

    public class ContractEmployeeFixed : IContractWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalculateWorkedSalary() => HourlyRate * HoursInMonth;
    }
}
