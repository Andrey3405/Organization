using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Organization.Presenter
{
    class OrganizationPresenter
    {
        private Model.OrganizationModel model;
        private View.IOrganizationView view;
        private Class.Tables tables;

        public OrganizationPresenter(View.IOrganizationView _view)
        {
            model = new Model.OrganizationModel();
            view = _view;

            tables = model.GetTables();
            Dictionary<int, string> employeeStatusDictionary 
                = model.GetDictionaryEmployeeStatus(tables.EmployeeStatus);

            Dictionary<int, string> dictionary
                = model.GetDictionaryEmployeeStatus(tables.EmployeeStatus);
            view.CBEmployeeStatus.SetItems(dictionary);
            view.Load += OnForm_Load;

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(tables.DepartmentTable);
            dataSet.Tables.Add(tables.EmployeeStatus);
            dataSet.Tables.Add(tables.EmployeeTable);
            dataSet.Tables.Add(tables.RelationTable);

            view.DGVOrgDataGridView.DataSource = tables.EmployeeTable;

            DataTable table = new DataTable();
            dataSet.Relations.Add("RelationDepartment", dataSet.Tables["Relation"].Columns["DepartmentID"]
                , dataSet.Tables["Department"].Columns["ID"],false);
            dataSet.Relations.Add("RelationEmployee", dataSet.Tables["Relation"].Columns["EmployeeID"]
                , dataSet.Tables["Employee"].Columns["ID"], false);
            dataSet.Relations.Add("RelationStatus", dataSet.Tables["Relation"].Columns["StatusID"]
                , dataSet.Tables["EmployeeStatus"].Columns["ID"], false);
            foreach (DataRow row in dataSet.Tables["Relation"].Rows)
            {
                //Console.WriteLine(row["Position"].ToString());
                string employee = string.Empty;
                string department = string.Empty;
                string status = string.Empty;
                string positiob = string.Empty;
                Console.WriteLine();
                foreach (DataRow employeeRow in row.GetChildRows(dataSet.Relations["RelationEmployee"]))
                {
                    Console.Write(employeeRow["Surname"] + " " + employeeRow["Name"] + " " + employeeRow["Patronymic"]+" ");
                }

                foreach(DataRow departmentRow in row.GetChildRows(dataSet.Relations["RelationDepartment"]))
                {
                    Console.Write(departmentRow["Name"]+" ");
                }

                foreach(DataRow statusRow in row.GetChildRows(dataSet.Relations["RelationStatus"]))
                {
                    Console.Write(statusRow["Name"] + " ");
                }
            }

            //view.DGVOrgDataGridView.DataSource = ta;
        }

        private void OnForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
