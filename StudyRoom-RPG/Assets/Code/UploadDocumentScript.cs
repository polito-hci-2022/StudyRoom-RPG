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
    public GameObject overwrite_modal;
    Mode mode;
    string document_name;
    void OnEnable()
    {
        mode = Mode.NotUploaded;
        upload_b.interactable = false;
        if (!DocumentList.instance.GetDocumentsOnTable().Exists( x => x.title == document_name)) {
            modal_text.fontSize = 65;
            modal_text.text = "What actions would you like other students\ncould perform on " + document_name + "?";
        }
        else {
            modal_text.fontSize = 50;
            modal_text.text = "A document called "+ document_name + " is already present on the table: if you continue it will be overwritten.\n\nDo you want to copy it anyway?";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UploadDocument(Text document_name) {
        this.document_name = document_name.text;
        DocumentList.instance.SetOpenDoc(document_name);
    }

    public void SetMode(int mode) {
        this.mode = (Mode) mode;
        upload_b.interactable = true;
    }

    public void ConfirmUpload() {
        DocumentList.instance.UploadDocument(document_name, mode);
    }

}
