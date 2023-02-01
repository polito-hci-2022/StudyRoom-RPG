using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DownloadModalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        gameObject.transform.GetChild(2).GetComponent<Text>().text = "Do you want to download " + DocumentList.instance.GetOpenDoc().title + "?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
