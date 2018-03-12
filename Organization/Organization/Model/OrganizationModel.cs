using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Organization.Model
{
    internal class OrganizationModel
    {
        public const string RecordAll = "(Все)"; 

        /// <summary>
        /// Создание таблиц с данными
        /// </summary>
        public Class.Tables GetTables()
        {
            return Class.Tables.GetInstance();
        }

        /// <summary>
        /// Преобразовать данные таблицы в Dictionary
        /// </summary>
        public Dictionary<int,string> GetDictionaryEmployeeStatus(DataTable employeeStatusTable)
        {
            Dictionary<int, string> returnValue = new Dictionary<int, string>();
            returnValue.Add(-1, RecordAll);
            if (employeeStatusTable != null)
            {
                foreach(DataRow rows in employeeStatusTable.Rows)
                {
                    returnValue.Add(Convert.ToInt32(rows[Data.ColumnName.ID]),
                        rows[Data.ColumnName.Name].ToString());
                }
            }
            return returnValue;
        }

        /// <summary>
        /// Создать DataSet с указанными таблицами
        /// </summary>
        /// <param name="listDataTable">Список таблиц, для добавления в DataSet</param>
        public DataSet CreateDataSet(params DataTable[] listDataTable)
        {
            if (listDataTable.Length == 0) return null;
            DataSet returnDataSet = new DataSet();
            for(int tableIndex = 0;tableIndex<listDataTable.Length;tableIndex++)
            {
                returnDataSet.Tables.Add(listDataTable[tableIndex]);
            }
            return returnDataSet;
        }
        
        /// <summary>
        /// Создать связи между таблицами в DataSet
        /// </summary>
        /// <param name="dataSet">DataSet в котором создаются связи</param>
        public void CreateRelationForDataSet(DataSet dataSet)
        {
            dataSet.Relations.Add(Data.RelationName.RelationDepartment
                ,dataSet.Tables[Data.TableName.Relation].Columns[Data.ColumnName.DepartmentID]
                ,dataSet.Tables[Data.TableName.Department].Columns[Data.ColumnName.ID], false);
            dataSet.Relations.Add(Data.RelationName.RelationEmployee
                ,dataSet.Tables[Data.TableName.Relation].Columns[Data.ColumnName.EmployeeID]
                ,dataSet.Tables[Data.TableName.Employee].Columns[Data.ColumnName.ID], false);
            dataSet.Relations.Add(Data.RelationName.RelationStatus
                ,dataSet.Tables[Data.TableName.Relation].Columns[Data.ColumnName.StatusID]
                ,dataSet.Tables[Data.TableName.EmployeeStatus].Columns[Data.ColumnName.ID], false);
        }

        /// <summary>
        /// Получить строковое представление по значению перечисления
        /// </summary>
        public string GetValueForGender(Gender.Gender gender)
        {
            if (gender == Gender.Gender.Male)
            {
                return "Мужчина";
            }
            else if (gender == Gender.Gender.Female)
            {
                return  "Женщина";
            }
            else return String.Empty;
        }

        /// <summary>
        /// Заполнить таблицу данными в соответствие с связью
        /// </summary>
        /// <param name="dataSet">DataSet с данными и связями</param>
        /// <param name="table">Таблица для заполнения</param>
        public void GetTableAfterRelation(DataSet dataSet, DataTable table)
        {
            //Создание результирующей таблицы
            if (dataSet == null || table == null) return;
            
            foreach(DataRow row in dataSet.Tables[Data.TableName.Relation].Rows)
            {
                DataRow newRow = table.NewRow();
                newRow[Data.ColumnName.Position] = row[Data.ColumnName.Position];
                newRow[Data.ColumnName.DateOfDismissal] = row[Data.ColumnName.DateOfDismissal];
                newRow[Data.ColumnName.DateOfHiring] = row[Data.ColumnName.DateOfHiring];
                foreach (DataRow employeeRow in row.GetChildRows(dataSet.Relations[Data.RelationName.RelationEmployee]))
                {
                    newRow[Data.ColumnName.EmployeeID] = employeeRow[Data.ColumnName.ID];
                    newRow[Data.ColumnName.Photo] = employeeRow[Data.ColumnName.Photo];
                    newRow[Data.ColumnName.Surname] = employeeRow[Data.ColumnName.Surname];
                    newRow[Data.ColumnName.Name] = employeeRow[Data.ColumnName.Name];
                    newRow[Data.ColumnName.Patronymic] = employeeRow[Data.ColumnName.Patronymic];
                    newRow[Data.ColumnName.Gender] = GetValueForGender((Gender.Gender)employeeRow[Data.ColumnName.Gender]);
                    newRow[Data.ColumnName.DateOfBirth] = employeeRow[Data.ColumnName.DateOfBirth];
                }

                foreach (DataRow departmentRow in row.GetChildRows(dataSet.Relations[Data.RelationName.RelationDepartment]))
                {
                    newRow[Data.ColumnName.DepartmentID] = departmentRow[Data.ColumnName.ID];
                    newRow[Data.ColumnName.DepartmentName] = departmentRow[Data.ColumnName.Name];
                }

                foreach (DataRow statusRow in row.GetChildRows(dataSet.Relations[Data.RelationName.RelationStatus]))
                {
                    newRow[Data.ColumnName.EmployeeStatusID] = statusRow[Data.ColumnName.ID];
                    newRow[Data.ColumnName.EmployeeStatusName] = statusRow[Data.ColumnName.Name];
                }
                table.Rows.Add(newRow);
            }
        }
    }
}
