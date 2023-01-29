using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class YourNotesScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject note1, note2;
    void Start()
    {
        CheckWhatOnTable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckWhatOnTable()
    {
        List<Document> table_docs = DocumentList.instance.GetDocumentsOnTable();
        if (table_docs.Exists(x => note1.transform.GetChild(0).GetChild(0).GetComponent<Text>().text == x.title))
        {
            note1.transform.GetChild(1).GetComponent<Button>().interactable = false;
        }
        if (table_docs.Exists(x => note2.transform.GetChild(0).GetChild(0).GetComponent<Text>().text == x.title))
        {
            note2.transform.GetChild(1).GetComponent<Button>().interactable = false;
        }
    }
}
