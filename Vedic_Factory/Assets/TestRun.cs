using UnityEngine;
using System.Collections;
using FactoryUtilities;
using System.Collections.Generic;

public class TestRun : MonoBehaviour {

    bool virgin;
	// Use this for initialization
	void Start () {
        virgin = true;
	}
	
	// Update is called once per frame
	void Update () {

        if(virgin)
        {
            virgin = false;
            T_Column col1 = new T_Column();
            col1.Name = "Name1";
            col1.ColumnKey = 0;

            T_Column col2 = new T_Column();
            col2.Name = "Name2";
            col2.ColumnKey = 1;

            List <T_Column> colSet = new List<T_Column>();
            colSet.Add(col1);
            colSet.Add(col2);

            List<T_Column> colSet2 = new List<T_Column>();
            colSet2.Add(col1);
            colSet2.Add(col2);

            T_Table tab1 = new T_Table();
            tab1.TableKey = 0;
            tab1.Name = "TabName1";
            tab1.ChildColumns = colSet;

            T_Table tab2 = new T_Table();
            tab2.TableKey = 1;
            tab2.Name = "TabName2";
            tab2.ChildColumns = colSet2;

            List<T_Table> tabSet = new List<T_Table>();
            tabSet.Add(tab1);
            tabSet.Add(tab2);

            T_Harness harness = new T_Harness();
            harness.childTables = tabSet;

            GameObject sample = ViewAssembler.GenerateViewObject(harness);
            sample.name = "Rex";

            

            

        }
	
	}
}
