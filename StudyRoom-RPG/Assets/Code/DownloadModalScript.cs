using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DownloadModalScript : MonoBehaviour
{
    string document_name;
    // Start is called before the first frame update
    void OnEnable()
    {
        if (!DocumentList.instance.GetMyDocuments().Exists( x => x.title == document_name)) {
            gameObject.transform.GetChild(2).GetComponent<Text>().text = "Do you want to download " + document_name + "?";    
        }
        else {
            gameObject.transform.GetChild(2).GetComponent<Text>().text = "A document called "+ document_name + " is already present in your notes: if you continue it will be overwritten.\n\nDo you want to download it anyway?";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DownloadDocument(Text document_name) {
        this.document_name = document_name.text;
        DocumentList.instance.SetOpenDoc(document_name);
    }

    public void ConfirmDownload() {
        DocumentList.instance.DownloadDocument(document_name);
        Debug.Log("DOWNLOADED "+ document_name);
    }

}
