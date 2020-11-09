using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Exercises_46-2018
{
    class ExerciseResult
    {
        private int ID { get; set; }
        private string StudentName { get; set; }
        private string StudentIndex { get; set; }
        private int Points { get; set; }

        public ExerciseResult(int ID, string StudentName, string StudentIndex, int Points)
        {
            this.ID = ID;
            this.StudentName = StudentName;
            this.StudentIndex = StudentIndex;
            this.Points = Points;
        }
        public override string ToString()
        {
            return "ID= " + ID + ", Student Name: " + StudentName + ", Student Index: " + StudentIndex + ", Points: " + Points;
        }
    }
}