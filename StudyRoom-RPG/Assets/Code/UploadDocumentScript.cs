using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UploadDocumentScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text modal_text;
    public Button upload_b;
    Mode mode;
    string document_name;
    void OnEnable()
    {
        mode = Mode.NotUploaded;
        upload_b.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UploadDocument(string document_name) {
        modal_text.text = "How do you want to upload " + document_name + "?";
        this.document_name = document_name;
    }

    public void SetMode(int mode) {
        this.mode = (Mode) mode;
        upload_b.interactable = true;
    }

    public void ConfirmUpload() {
        DocumentList.instance.UploadDocument(document_name, mode);
    }

}
