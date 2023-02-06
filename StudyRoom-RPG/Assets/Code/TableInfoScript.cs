using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TableInfoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text table_data = gameObject.transform.GetChild(2).GetComponent<Text>();
        table_data.text = "Table: " + Table.instance.table_name + "\nCode: " + Table.instance.table_code + "\nSubject: " + Table.instance.subject + "\nPrivacy: " + Table.instance.privacy + "\nPeople at the table: 4/4 - FULL" ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
