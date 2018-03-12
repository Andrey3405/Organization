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
        private DataTable tableForDGV;

        public OrganizationPresenter(View.IOrganizationView _view)
        {
            model = new Model.OrganizationModel();
            view = _view;

            tables = model.GetTables();

            Dictionary<int, string> dictionary
                = model.GetDictionaryEmployeeStatus(tables.EmployeeStatus);
            view.CBEmployeeStatus.SetItems(dictionary);
            

            DataSet dataSet = model.CreateDataSet(tables.DepartmentTable
                                                ,tables.EmployeeStatus
                                                ,tables.EmployeeTable
                                                ,tables.RelationTable);


            tableForDGV = CreateTable.Create(new AfterRelationTableCreator());
            model.CreateRelationForDataSet(dataSet);
            model.GetTableAfterRelation(dataSet, tableForDGV);
            view.DGVRelation.DataSource = tableForDGV;

            view.Load += OnForm_Load;
            view.BtnTableMode.CheckedChanged += OnButtonTableMode_CheckedChanged;
            OnButtonTableMode_CheckedChanged(new object(), EventArgs.Empty);
        }

        private void OnButtonTableMode_CheckedChanged(object sender,EventArgs e)
        {
            if (view.BtnTableMode.Checked)
            {
                SetTableMode();
            }
            else
            {
                GetInfo();
                SetInfoMode();
            }
        }

        /// <summary>
        /// Получить полную информацию о сотруднике и записать ее в ячейку 
        /// </summary>
        private void GetInfo()
        {
            for (int rowIndex = 0; rowIndex < tableForDGV.Rows.Count; rowIndex++)
            {
                //Записать ФИО
                string employee 
                    = $"{tableForDGV.Rows[rowIndex][Data.ColumnName.Surname]} " +
                      $"{tableForDGV.Rows[rowIndex][Data.ColumnName.Name]} " +
                      $"{tableForDGV.Rows[rowIndex][Data.ColumnName.Patronymic]}";

                string dateOfBirth
                    = Convert.ToDateTime(tableForDGV.Rows[rowIndex][Data.ColumnName.DateOfBirth]).ToShortDateString();
                string dateOfDismissal = String.Empty;

                if (!String.IsNullOrEmpty(tableForDGV.Rows[rowIndex][Data.ColumnName.DateOfDismissal].ToString()))
                {
                    dateOfDismissal
                        = Convert.ToDateTime(tableForDGV.Rows[rowIndex][Data.ColumnName.DateOfDismissal]).ToShortDateString();
                }

                string dateOfHiring
                    = Convert.ToDateTime(tableForDGV.Rows[rowIndex][Data.ColumnName.DateOfHiring]).ToShortDateString();

                //Записать полную информацию в ячейку
                tableForDGV.Rows[rowIndex][Data.ColumnName.TableInfo]
                    = $"Сотрудник: {employee} {Environment.NewLine}" +
                      $"Пол: {tableForDGV.Rows[rowIndex][Data.ColumnName.Gender]} {Environment.NewLine}" +
                      $"Дата рождения: {dateOfBirth} {Environment.NewLine}" +
                      $"Отдел: {tableForDGV.Rows[rowIndex][Data.ColumnName.DepartmentName]} {Environment.NewLine}" +
                      $"Статус сотрудника: {tableForDGV.Rows[rowIndex][Data.ColumnName.EmployeeStatusName]} {Environment.NewLine}"  +
                      $"Дата найма: {dateOfHiring} {Environment.NewLine}" +
                      $"Дата увольнения: {dateOfDismissal} {Environment.NewLine}";
            }
        }

        /// <summary>
        /// Установить видимость столбцов в соответствение с табличным видом
        /// </summary>
        private void SetTableMode()
        {
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.EmployeeID, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DepartmentID, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.EmployeeStatusID, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.TableInfo, false);            
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Photo, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Surname, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Name, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Patronymic, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Gender, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DateOfBirth, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DepartmentName, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.EmployeeStatusName, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DateOfHiring, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DateOfDismissal, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Position, true);
        }

        /// <summary>
        /// Установить видимость столбцов в соответствение с компактным видом
        /// </summary>
        private void SetInfoMode()
        {
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.EmployeeID, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DepartmentID, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.EmployeeStatusID, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.TableInfo, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Photo, true);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Surname, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Name, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Patronymic, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Gender, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DateOfBirth, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DepartmentName, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.EmployeeStatusName, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DateOfHiring, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DateOfBirth, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.DateOfDismissal, false);
            view.DGVRelation.SetColumnVisibility(Data.ColumnName.Position, false);
        }

        private void OnForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
