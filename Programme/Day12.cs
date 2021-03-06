﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Person2
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person2() { }
        public Person2(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person2
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student(string firstName, string lastName, int id, int[] scores)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            base.id = id;
            testScores = scores;
        }
        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            int sum = 0;

            foreach (int marks in testScores)
            {
                sum += marks;
            }

            decimal avgMarks = (decimal)(sum / testScores.Length);

            if (avgMarks >= 90 && avgMarks <= 100)
                return 'O';
            else if (avgMarks >= 80 && avgMarks < 90)
                return 'E';
            else if (avgMarks >= 70 && avgMarks < 80)
                return 'A';
            else if (avgMarks >= 55 && avgMarks < 70)
                return 'P';
            else if (avgMarks >= 40 && avgMarks < 55)
                return 'D';
            else
                return 'T';
        }
    }

    class Day12
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");

            Console.ReadLine();
        }
    }
}
