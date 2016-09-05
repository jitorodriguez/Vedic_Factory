using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace FactoryUtilities {

    public enum View_Type { Harness, Table, Column };

    public struct T_Column
    {
        private int key;
        private string fieldName;
        
        public int ColumnKey
        {
            get
            {
                return key;
            }
            set
            {
                if(value < 0)
                {
                    key = -1;
                }
                else
                {
                    key = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return fieldName;
            }
            set
            {
                fieldName = value;
            }
        }
    }

    public struct T_Table
    {
        private int key;
        private string tableName;
        private List<T_Column> childCols;

        public int TableKey
        {
            get
            {
                return key;
            }
            set
            {
                if (value < 0)
                {
                    key = -1;
                }
                else
                {
                    key = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
            }
        }

        public List<T_Column> ChildColumns
        {
            get
            {
                return childCols;
            }
            set
            {
                childCols = value;
            }
        }

    }

    public struct T_Harness
    {
        private string databaseName;
        public List<T_Table> childTables;

    }



	// Use this for initialization
	
}
