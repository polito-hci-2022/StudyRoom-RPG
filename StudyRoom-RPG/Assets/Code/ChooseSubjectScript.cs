using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSubjectScript : MonoBehaviour
{

    Button next_b;
    //GameObject selection;

    // Start is called before the first frame update
    void Start()
    {
        next_b = gameObject.transform.GetChild(2).gameObject.GetComponent<Button>();
        next_b.interactable = false;
    }


    // Update is called once per frame
    void Update()
    {
        //selection = gameObject.transform.GetChild(3).gameObject.transform.GetChild(0);
    }
}
