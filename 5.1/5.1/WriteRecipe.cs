﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class WriteRecipe : ActionWithPatient
    {
        public override void Do(PatientCard patientCard, EmployeeHandler employeeHandler)
        {
            base.Do(patientCard, employeeHandler);
            Console.WriteLine("Введите рецепт:");
            string Recipy = Console.ReadLine();
            Record record = new Record(Recipy, base.Comment);
            patientCard.Records.Insert(record);


        }

    }
}