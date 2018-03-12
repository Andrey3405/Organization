using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    class CreateTable
    {
        public static DataTable Create(TableCreator creator)
        {
            return creator.Table;
        }
    }

    abstract class TableCreator
    {
        public DataTable Table { get; private set; }

        public TableCreator()
        {
            Table = new DataTable();
            SetNameTable();
            CreateColumns();
            CreatePrimaryKey();
            FillData();
        }

        protected abstract void SetNameTable();
        protected abstract void CreateColumns();
        protected virtual void CreatePrimaryKey()
        {
            if(Table.Columns["ID"]!= null)
                Table.PrimaryKey = new DataColumn[] { Table.Columns["ID"] };
        }
        protected abstract void FillData();
    }

    class EmployeeTableCreator : TableCreator
    {
        protected override void SetNameTable()
        {
            Table.TableName = Data.TableName.Employee;
        }

        protected override void CreateColumns()
        {
            Table.Columns.Add(Data.ColumnName.ID,typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.Photo, typeof(Image))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.Surname, typeof(string))
                .Caption = "Фамилия";
            Table.Columns.Add(Data.ColumnName.Name, typeof(string))
                .Caption = "Имя";
            Table.Columns.Add(Data.ColumnName.Patronymic, typeof(string))
                .Caption = "Отчество";
            Table.Columns.Add(Data.ColumnName.Gender, typeof(Gender.Gender))
                .Caption = "Пол";
            Table.Columns.Add(Data.ColumnName.DateOfBirth, typeof(DateTime))
                .Caption = "Дата рождения";
        }

        protected override void FillData()
        {
            Gender.Gender female = Gender.Gender.Female;
            Gender.Gender male = Gender.Gender.Male;
            Table.Rows.Add(1, null, "Белозерова", "Милена", "Григорьевна", female, Convert.ToDateTime("08.08.1994"));
            Table.Rows.Add(2, null, "Рзаева", "Тамара", "Антоновна", female, Convert.ToDateTime("16.03.1981"));
            Table.Rows.Add(3, null, "Охота", "Рада", "Яковлевна", female, Convert.ToDateTime("14.08.1972"));
            Table.Rows.Add(4, null, "Андронов", "Артемий", "Тимофеевич", male, Convert.ToDateTime("19.02.1987"));
            Table.Rows.Add(5, null, "Кудрявцев", "Константин", "Константинович", male, Convert.ToDateTime("15.07.1975"));
            Table.Rows.Add(6, null, "Волков", "Константин", "Давидович", male, Convert.ToDateTime("03.12.1981"));
            Table.Rows.Add(7, null, "Ильин", "Парфен", "Максович", male, Convert.ToDateTime("01.04.1975"));
            Table.Rows.Add(8, null, "Максимова", "Флора", "Валерьевна", female, Convert.ToDateTime("09.08.1971"));
            Table.Rows.Add(9, null, "Козлова", "Каролина", "Платоновна", female, Convert.ToDateTime("22.12.1967"));
            Table.Rows.Add(10, null, "Тимофеев", "Николай", "Николаевич", male, Convert.ToDateTime("11.09.1969"));

            string path = $"{System.Windows.Forms.Application.StartupPath}\\Information\\Photos";
            if (Directory.Exists(path))
            {
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    Table.Rows[i][Data.ColumnName.Photo]
                        = Class.ImageExtension.GetBitmapFromPath($"{path}\\{Table.Rows[i][Data.ColumnName.ID]}.png",150,150); 
                }
            }
        }
    }

    class DepartmentTableCreator : TableCreator
    {
        protected override void SetNameTable()
        {
            Table.TableName = Data.TableName.Department;
        }

        protected override void CreateColumns()
        {
            Table.Columns.Add(Data.ColumnName.ID, typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.Name, typeof(string))
                .Caption = "Отдел";
        }

        protected override void FillData()
        {
            Table.Rows.Add(1, "Отдел перевозок");
            Table.Rows.Add(2, "Технический отдел");
            Table.Rows.Add(3, "Маркетинг");
        }
    }

    class EmployeeStatusTableCreator : TableCreator
    {
        protected override void SetNameTable()
        {
            Table.TableName = Data.TableName.EmployeeStatus;
        }

        protected override void CreateColumns()
        {
            Table.Columns.Add(Data.ColumnName.ID, typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.Name, typeof(string))
                .Caption = "Статус сотрудника";
        }

        protected override void FillData()
        {
            Table.Rows.Add(1, "Принят");
            Table.Rows.Add(2, "Уволен");
            Table.Rows.Add(3, "Отпуск");
            Table.Rows.Add(4, "Больничный");
        }
    }

    class RelationTableCreator : TableCreator
    {
        protected override void SetNameTable()
        {
            Table.TableName = Data.TableName.Relation;
        }

        protected override void CreateColumns()
        {
            Table.Columns.Add(Data.ColumnName.ID, typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.EmployeeID, typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.DepartmentID, typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.DateOfHiring, typeof(DateTime))
                .Caption = "Дата найма";
            Table.Columns.Add(Data.ColumnName.Position, typeof(string))
                .Caption = "Должность";
            Table.Columns.Add(Data.ColumnName.DateOfDismissal, typeof(DateTime))
                .Caption = "Дата увольнения";
            Table.Columns.Add(Data.ColumnName.StatusID, typeof(int))
                .Caption = String.Empty; ;
        }

        protected override void FillData()
        {
            Table.Rows.Add(1, 1, 3, Convert.ToDateTime("28.10.2015"), "Специалист", null, 3);
            Table.Rows.Add(2, 2, 3, Convert.ToDateTime("29.01.2016"), "Начальник отдела", null, 1);
            Table.Rows.Add(3, 3, 1, Convert.ToDateTime("31.03.2016"), "Оператор", null, 1);
            Table.Rows.Add(4, 4, 1, Convert.ToDateTime("18.08.2016"), "Водитель", null, 1);
            Table.Rows.Add(5, 5, 2, Convert.ToDateTime("09.06.2017"), "Начальник отдела", null, 4);
            Table.Rows.Add(6, 6, 2, Convert.ToDateTime("23.03.2015"), "Механик", null, 1);
            Table.Rows.Add(7, 7, 1, Convert.ToDateTime("27.05.2015"), "Водитель", null, 4);
            Table.Rows.Add(8, 8, 1, Convert.ToDateTime("28.09.2015"), "Водитель", Convert.ToDateTime("27.04.2017"), 2);
            Table.Rows.Add(9, 9, 2, Convert.ToDateTime("27.10.2015"), "Технический работник", null, 1);
            Table.Rows.Add(10, 10, 1, Convert.ToDateTime("25.05.2016"), "Начальник отдела", null, 3);
        }
    }

    class AfterRelationTableCreator: TableCreator
    {
        protected override void CreatePrimaryKey() { }
        protected override void FillData() { }

        protected override void SetNameTable()
        {
            Table.TableName = Data.TableName.AfterRelation;
        }

        protected override void CreateColumns()
        {
            Table.Columns.Add(Data.ColumnName.EmployeeID, typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.Photo, typeof(Image))
                .Caption = "Фото";
            Table.Columns.Add(Data.ColumnName.Surname, typeof(string))
                .Caption = "Фамилия";
            Table.Columns.Add(Data.ColumnName.Name, typeof(string))
                .Caption = "Имя";
            Table.Columns.Add(Data.ColumnName.Patronymic,typeof(string))
                .Caption = "Отчество" ;
            Table.Columns.Add(Data.ColumnName.Gender, typeof(string))
                .Caption = "Пол";
            Table.Columns.Add(Data.ColumnName.DateOfBirth, typeof(DateTime))
                .Caption = "Дата рождения";
            Table.Columns.Add(Data.ColumnName.DepartmentID, typeof(int))
                .Caption = String.Empty;
            Table.Columns.Add(Data.ColumnName.DepartmentName, typeof(string))
                .Caption = "Отдел";
            Table.Columns.Add(Data.ColumnName.Position, typeof(string))
                .Caption = "Должность";
            Table.Columns.Add(Data.ColumnName.DateOfDismissal, typeof(DateTime))
                .Caption = "Дата увольнения";
            Table.Columns.Add(Data.ColumnName.EmployeeStatusID, typeof(int))
                .Caption = String.Empty; 
            Table.Columns.Add(Data.ColumnName.EmployeeStatusName, typeof(string))
                .Caption = "Статус сотрудника";
            Table.Columns.Add(Data.ColumnName.DateOfHiring, typeof(DateTime))
                .Caption = "Дата найма";
            Table.Columns.Add(Data.ColumnName.TableInfo, typeof(string))
                .Caption = "Полная информация о сотруднике";
        }
    }
}
