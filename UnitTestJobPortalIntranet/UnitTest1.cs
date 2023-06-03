using JobPortalIntranetLibraryClass.modeleFluent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BusinessLayer;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestJobPortalIntranet
{
    [TestClass]
    public class UnitTestEmploye
    {

        private Manager manager = Manager.Instance;

        [TestMethod]
        public void TestGetAllEmploye() {
            List<Employe> employees = manager.GetAllEmploye();
            Console.WriteLine(employees.Count);
            // Assert
            Assert.IsNotNull(employees, "List of employees should not be null");
        }

        [TestMethod]
        public void TestAddEmployee()
        {
            Employe employe = new Employe();
            employe.Firstname = "Test";
            employe.Lastname = "Test";
            employe.Biography = "Test";
            employe.Seniority = 5;
            employe.Dateofbirth = DateTime.Now;
            manager.AddEmploye(employe);
            List<Employe> employes = manager.GetAllEmploye();
            Assert.IsTrue(employes.Contains(employe));
        }

        [TestMethod]
        public void TestUpdateEmployee() {
            Employe employe = new Employe();
            employe.Firstname = "Test";
            employe.Lastname = "Test";
            employe.Biography = "Test";
            employe.Seniority = 5;
            employe.Dateofbirth = DateTime.Now;
            manager.AddEmploye(employe);
            employe.Firstname = "Test2";
            employe.Lastname = "Test2";
            manager.UpdateEmploye(employe);
            Employe updatedEmployee = manager.GetEmployeById(employe.Id);
            Assert.IsNotNull(updatedEmployee, "Updated employee should exist");
            Assert.AreEqual("Test2", updatedEmployee.Firstname, "Employee Firstname should be updated");
            Assert.AreEqual("Test2", updatedEmployee.Lastname, "Employee Lastname should be updated");
        }

        [TestMethod]
        public void TestRemoveEmployee()
        {
            Employe employeeToDelete = new Employe();
            employeeToDelete.Firstname = "Test";
            employeeToDelete.Lastname = "Test";
            employeeToDelete.Biography = "Test";
            employeeToDelete.Seniority = 5;
            employeeToDelete.Dateofbirth = DateTime.Now;
            manager.AddEmploye(employeeToDelete);
            manager.DeleteEmploye(employeeToDelete.Id);

            List<Employe> employees = manager.GetAllEmploye();

            // Assert
            Assert.IsFalse(employees.Contains(employeeToDelete), "Deleted employee should not be in the list");

        }
    }
}
