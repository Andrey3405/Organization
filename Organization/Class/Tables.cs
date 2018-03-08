using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Class
{
    //Класс для доступа к созданным таблицам (имитация выборки с сервера)
    class Tables
    {
        public DataTable EmployeeTable{ get; private set; }
        public DataTable DepartmentTable { get; private set; }
        public DataTable EmployeeStatus { get; private set; }
        public DataTable RelationTable { get; private set; }

        private static Tables instance;

        private Tables()
        {
            DepartmentTable = CreateTable.Create(new DepartmentTableCreator());
            EmployeeTable = CreateTable.Create(new EmployeeTableCreator());
            EmployeeStatus = CreateTable.Create(new EmployeeStatusTableCreator());
            RelationTable = CreateTable.Create(new RelationTableCreator());
        }

        public static Tables GetInstance()
        {
            if(instance == null)
            {
                instance = new Tables();
            }
            return instance;
        }
    }
}
