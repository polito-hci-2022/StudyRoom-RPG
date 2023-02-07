using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CreateTableScript : MonoBehaviour
{
    public Button next_b;
    public InputField input_name;
    public Text subject;
    Privacy privacy;
    string table_name;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //name is child 2 because a Caret is automaticly added when the InputField is used
        table_name = input_name.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        next_b.interactable = (table_name != "" && privacy != Privacy.Undefined);
    }

    public void OnTableConfirmation()
    {
        Table.instance.table_name = table_name;
        Table.instance.table_code = "100001";
        Table.instance.privacy = privacy;
    }

    public void SetPrivacy(int val) {
        privacy = (Privacy) val;
    }

    void OnEnable () {
        subject.text = "Chosen Subject: " + Table.instance.subject;
        privacy = Privacy.Undefined;
    }
}
