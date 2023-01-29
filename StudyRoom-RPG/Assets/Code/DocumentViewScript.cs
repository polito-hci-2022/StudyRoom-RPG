using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DocumentViewScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text document_name;
    void OnEnable()
    {
        Debug.Log("ONENABLE");
        document_name.text = DocumentList.instance.GetOpenDoc().title;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
