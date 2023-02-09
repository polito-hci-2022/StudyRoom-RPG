using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UploadStatusModalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        gameObject.transform.GetChild(2).GetComponent<Text>().text = DocumentList.instance.GetOpenDoc().title + " correctly copied!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}