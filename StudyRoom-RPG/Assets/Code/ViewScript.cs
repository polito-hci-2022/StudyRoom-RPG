using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ViewScript : MonoBehaviour
{
    public MoveToScene mts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(Text name) {
        DocumentList.instance.SetOpenDoc(name);
        mts.NextScene("DocumentScene");
    }
}
