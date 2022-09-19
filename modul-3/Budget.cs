using System;

namespace Modul_3
{
    class Budget
    {
        private int _budgetID;
        private float _nominal;
        private string _title;
        private string _category;

        public int BudgetID
        {
            get { return _budgetID; }
        }

        public float Nominal
        {
            get { return _nominal; }
            set { _nominal = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; } 
        }

        private string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        public Budget( float nominal, string title, string categoryName)
        {
            Nominal = nominal;
            Title = title;
            CategoryName = categoryName;
        }

        public override string ReadBudget()
        {
            return String.Format("Anda memiliki anggaran {0} sebesar {1} di kategori {2}", 
                this.Title, this.Nominal, this.CategoryName);
        }

    
    }
}