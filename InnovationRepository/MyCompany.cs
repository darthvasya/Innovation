using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;

namespace InnovationRepository
{
    public class MyCompany : Father, IObject
    {
        Entities context;
        public static int selectedCompany { get; set; }
        public static int selectedInnovation { get; set; }
        public string errMessage { get; private set; }


        public MyCompany()
        {
            try
            {
                context = new Entities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public virtual void getInformation()
        {
            //some actions
            throw new NotImplementedException();
        }

        public virtual void addNewItem()
        {
            //some actions
            MessageBox.Show("Объект успешно добавлен");
            throw new NotImplementedException();
        }

        public virtual string getError(Exception ex)
        {
            if (ex.GetType().ToString() == "System.Data.Entity.Core.EntityException")
                return "Ошибка соединения. Проверьте сеть.";
            return "Неопознанная обшибка.";
        }
    }
}