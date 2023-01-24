using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StudyroomScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text table_data;
    void Start()
    {
        table_data.text = "Table: " + Table.instance.table_name + "\n" + "Code: " + Table.instance.table_code;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
