using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkwithDB
{
    class MySelect
    {
        internal MySelect()
        {
            names = new List<string>();
            bydef = new List<string>() { "Количество", "Сумма" };
            selectedcolumns = new List<int>();

    }
        internal List<string> names;
        internal List<string> bydef;
        internal List<int> selectedcolumns; 
        internal string standartquery()
        {
            return "SELECT Дата, Организация, Город, Страна, Менеджер, Количество, Сумма FROM Organization";
        }
        internal string query(string nametable)
        {
            string result = "SELECT "; 
            foreach(string name in names)
            {
                result += name + ", ";
            }
            for (int i = 0; i < bydef.Count; i++)
            {
                result += " SUM(" + bydef[i] + ") " + "AS " + bydef[i];
                if (i != bydef.Count - 1)
                    result += ",";
            }

            result += " FROM " + nametable;
            result += " GROUP BY ";
            for (int i = 0;  i < names.Count; i++)
            {
                if (i != names.Count - 1)
                    result += names[i] + ", ";
                else
                    result += names[i];
            }
            result += ";";
            return result; 
        }
    }
}
