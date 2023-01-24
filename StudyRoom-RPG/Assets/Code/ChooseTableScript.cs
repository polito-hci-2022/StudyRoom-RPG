using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChooseTableScript : MonoBehaviour
{

    public Button next_b;
    public VerticalLayoutGroup selection_group;
    List<Button> tables = new List<Button>();
    public Table table;
    string table_code, table_name;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<selection_group.transform.childCount; i++) {
            Button button = selection_group.transform.GetChild(i).gameObject.GetComponent<Button>();
            tables.Add(button);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void OnTableSelection(string code) {
        GameObject selected_object = EventSystem.current.currentSelectedGameObject;
        if (selected_object!=null && tables.Contains(selected_object.GetComponent<Button>())) {
            table_name = selected_object.transform.GetChild(0).GetComponent<Text>().text;
            table_code = code;
            next_b.interactable = true;
        }
        else {
            next_b.interactable = false;
        }
    }

    public void OnTableConfirmation() {
        table.table_name = table_name;
        table.table_code = table_code;
    }

    void OnEnable()
    {
        next_b.interactable = false;
    }
}
