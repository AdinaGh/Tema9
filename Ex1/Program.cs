
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySchoolDetails();
        }

        private static void DisplaySchoolDetails()
        {
            var disciplines = new List<Discipline>()
            {
                new Discipline()
                {
                    Name="disc.1",
                    NoOfExercises=1,
                    NoOfLectures=2
                },
                new Discipline()
                {
                    Name="disc.2",
                    NoOfExercises=3,
                    NoOfLectures=4
                },
                new Discipline()
                {
                    Name="disc.3",
                    NoOfExercises=5,
                    NoOfLectures=6
                }
            };
            var students = new List<Student>()
                        {
                            new Student()
                            {
                                ClassNumber = "ClNo.1",
                                Name="std1"
                            },
                            new Student()
                            {
                                ClassNumber = "ClNo.1",
                                Name="std2"
                            },
                            new Student()
                            {
                                ClassNumber = "ClNo.2",
                                Name="std3"
                            }
                        };
            var teachers = new List<Teacher>()
                        {
                            new Teacher()
                            {
                                Name="tc.1",
                                Disciplines = new List<Discipline>()
                                {
                                    disciplines[0]
                                }
                            },
                            new Teacher()
                            {
                                Name="tc.2",
                                 Disciplines = new List<Discipline>()
                                {
                                    disciplines[0],
                                    disciplines[1]
                                }
                            },
                            new Teacher()
                            {
                                Name="tc.3",
                                 Disciplines = new List<Discipline>()
                                {
                                    disciplines[1],
                                    disciplines[2]
                                }
                            },
                        };

            var sc = new School()
            {
                Name = "sc.1",
                Classes = new List<InHouseClass>()
                {
                    new InHouseClass()
                    {
                        UniqueNo="Id.1",
                        Teachers = new List<Teacher>()
                        {
                            teachers[0],
                            teachers[1]
                        },
                        Students = new List<Student>()
                        {
                            students[0],
                            students[1]
                        }
                    },
                    new InHouseClass()
                    {
                        UniqueNo="Id.2",
                        Students = new List<Student>()
                        {
                            students[1],
                            students[2]
                        }
                    }
                }
            };


            Console.WriteLine(sc.Print());
        }
    }
}

