using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ConfirmationModalScript : MonoBehaviour
{
    public Table table;
    public Text subject, table_name, code, privacy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable() {
        subject.text = "Subject: " + table.subject;
        table_name.text = "Table: " + table.table_name;
        code.text = "Code: " + table.table_code;
        privacy.text = "Privacy: " + table.privacy;
    }
}
