﻿using Core;
using DatabaseAccess.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System.Collections.Generic;

namespace Tests.DatabaseAccess
{
    [TestClass]
    public class EmployeeRepositoryTest
    {
        IEmployeeRepository employeeRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            employeeRepository = new EmployeeRepository();
        }

        [TestMethod]
        public void TestGetEmployeeByUsername()
        {
            Employee employee = employeeRepository.GetEmployeeByUsername("MikkelP");
            Assert.AreEqual("Mikkel Paulsen", employeeRepository.GetEmployeeByUsername("MikkelP").Name);
        }

        [TestMethod]
        public void TestInsertEmployeeIntoDb()
        {
            Employee emp = new Employee()
            {
                Name = "Anders Andersen",
                IsAdmin = false,
                Mail = "andersen@bos.dk",
                Phone = "98901349",
                NumbOfHours = 37,
                IsEmployed = true,
                Username = "AAndersen",
                DepartmentId = 3,
                Password = "GotMilk?"
            };

            employeeRepository.InsertEmployee(emp);

            emp = employeeRepository.GetEmployeeByUsername("AAndersen");
            List<Employee> emps = employeeRepository.GetAllEmployees();

            Assert.IsNotNull(emp);
            Assert.AreEqual("Anders Andersen", emp.Name);
            Assert.AreEqual(6, emp.Id);
            Assert.AreEqual(emps.Count, 6);
        }

        [TestMethod]
        public void TestUpdateEmployee()
        {
            Employee emp = employeeRepository.GetEmployeeByUsername("MikkelP");

            Assert.IsNotNull(emp);
            Assert.AreEqual("Mikkel Paulsen", emp.Name);

            emp.Name = "Mikkel Hansen";

            employeeRepository.UpdateEmployee(emp);

            emp = employeeRepository.GetEmployeeByUsername("MikkelP");
            Assert.IsNotNull(emp);
            Assert.AreEqual("Mikkel Hansen", emp.Name);

        }

        [TestCleanup]
        public void TestCleanup()
        {
            DBSetUp.SetUpDB();
        }

    }
}