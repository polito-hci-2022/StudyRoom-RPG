using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NotesOnTableScript : MonoBehaviour
{
    List<Document> document_list;
    public GameObject note1, note2, note3, note4;

    // Start is called before the first frame update
    void OnEnable()
    {
        GameObject[] notes = {note1, note2, note3, note4};
        document_list = DocumentList.instance.GetDocumentsOnTable();
        for (int i=0; i<document_list.Count; i++) {
            notes[i].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}