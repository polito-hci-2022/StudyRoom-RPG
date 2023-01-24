using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoinPrivateTableScript : MonoBehaviour
{
    public Button next_b;
    public Table table;
    public InputField input_code;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTableConfirmation() {
        string code = input_code.transform.GetChild(1).gameObject.GetComponent<Text>().text;
        if (code == "") {
            return;
        }
        table.table_name = "Hardcoded name";
        table.table_code = code;
    }
}
