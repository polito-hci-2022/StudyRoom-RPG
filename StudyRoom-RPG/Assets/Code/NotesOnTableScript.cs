using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NotesOnTableScript : MonoBehaviour
{
    List<Document> document_list;
    // Start is called before the first frame update
    void OnEnable()
    {
        document_list = DocumentList.instance.GetDocumentsOnTable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
