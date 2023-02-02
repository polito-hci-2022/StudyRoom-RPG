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
        gameObject.transform.GetChild(2).GetComponent<Text>().text = "Do you want to download " + document_name + "?";
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
