using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UploadDocumentScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text modal_text;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UploadDocument(string document_name) {
        modal_text.text = "How do you want to upload " + document_name + "?";
    }

    public void SetMode(int mode) {

    }
}
