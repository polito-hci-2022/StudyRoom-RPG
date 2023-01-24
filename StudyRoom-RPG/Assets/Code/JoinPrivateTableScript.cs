using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoinPrivateTableScript : MonoBehaviour
{
    public Button next_b;
    public InputField input_code;
    string code;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //code is child 2 because a Caret is automaticly added when the InputField is used
        code = input_code.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        next_b.interactable = (code != "");
    }

    public void OnTableConfirmation() {
        Table.instance.table_name = "Hardcoded name";
        Table.instance.table_code = code;
        Table.instance.privacy = Privacy.Private;
    }


}