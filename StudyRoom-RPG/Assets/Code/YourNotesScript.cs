using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class YourNotesScript : MonoBehaviour
{
    List<Document> document_list;
    public GameObject note1, note2, note3, note4;
    void OnEnable()
    {
        GameObject[] notes = {note1, note2, note3, note4};
        document_list = DocumentList.instance.GetMyDocuments();
        for (int i=0; i<document_list.Count; i++) {
            notes[i].transform.GetChild(0).GetChild(0).gameObject.GetComponent<Text>().text = document_list[i].title;
            notes[i].transform.GetChild(1).gameObject.GetComponent<Button>().interactable = (document_list[i].mode == Mode.NotUploaded);
            notes[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
