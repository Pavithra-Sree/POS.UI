using POS.DataAccess;
using POS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace POS.BusinessRules
{
    public class ClsEmployeeDataSystem
    {
        private SqlServerDataAccess objSqlServerDataaccess = new SqlServerDataAccess();
        public ClsEmployeeDataSystem() { }
        public bool AddEmployee(Employee objEmployee)
        {
            if (objSqlServerDataaccess.InsertEmployee(objEmployee) >= 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool  RemoveEmployee(Employee objEmployee)
        {
            if (objSqlServerDataaccess.DeleteEmployee(objEmployee) >= 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool AddAgainEmployee(Employee objEmployee)
        {
            if (objSqlServerDataaccess.UpdateEmployee(objEmployee) >= 1)
            {
                return true;
            }
            else
                return false;
        }

        public DataTable DisplayEmployee()
        {
            var res = objSqlServerDataaccess.FetchEmployee();
            return res;
        }
    }
}