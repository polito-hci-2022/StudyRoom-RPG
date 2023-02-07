using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoinPrivateTableScript : MonoBehaviour
{
    public Button next_b;
    public InputField input_code;
    public Text warning;
    public Text subject;

    string code;
    int i;
    // Start is called before the first frame update
    void OnEnable()
    {
        subject.text = "Chosen Subject: " + Table.instance.subject;
    }

    // Update is called once per frame
    void Update()
    {
        //code is child 2 because a Caret is automaticly added when the InputField is used
        code = input_code.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        if (code.Length == 6 && int.TryParse(code, out i)) {
            warning.text = "The inserted code is valid.";
            next_b.interactable = true;
        }
        else if (code.Length == 0) {
            warning.text = "";
            next_b.interactable = false;
        }
        else {
            warning.text = "The inserted code is not valid. It must be a 6-digit numeric code.";
            next_b.interactable = false;
        } 
    }

    public void OnTableConfirmation() {
        Table.instance.table_name = "Hardcoded name";
        Table.instance.table_code = code;
        Table.instance.privacy = Privacy.Private;
    }


}
