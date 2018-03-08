using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Organization.Model
{
    class OrganizationModel
    {
        public string RecordAll { get => "(Все)"; }

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
                    returnValue.Add(Convert.ToInt32(rows["ID"]),
                        rows["Name"].ToString());
                }
            }
            return returnValue;
        }

        public DataTable GetTableAfterRelation()
        {
            //Создание результирующей таблицы
            DataTable returnValue = new DataTable();
            //Создание набора данных
            //Добавление всех необходимых таблиц в набор данных
            //Создание связи в наборе данных
            //Заполнение результирующей таблицы данных
            //Вернуть эту таблицу
            return returnValue;
        }
    }
}
