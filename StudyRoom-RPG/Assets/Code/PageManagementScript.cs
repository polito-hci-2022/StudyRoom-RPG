using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PageManagementScript : MonoBehaviour
{
    Text page_number_text;
    Button next, previous;
    int page_number = 1;
    public Text note_text;

    // Start is called before the first frame update
    void Start()
    {
        page_number_text = gameObject.transform.GetChild(0).GetComponent<Text>();
        previous = gameObject.transform.GetChild(1).GetComponent<Button>();
        next = gameObject.transform.GetChild(2).GetComponent<Button>();
        page_number_text.text = "Page: " + page_number + "/3";
        previous.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPage () {
        page_number ++;
        page_number_text.text = "Page: " + page_number + "/3";
        if (page_number == 3) {
            next.interactable = false;
        }
        if (page_number != 1) {
            previous.interactable = true;
        }
        change_text();
    }

    public void PreviousPage() {
        page_number --;
        page_number_text.text = "Page: " + page_number + "/3";
        if (page_number == 1) {
            previous.interactable = false;
        }
        if (page_number != 3) {
            next.interactable = true;
        }
        change_text();
    }

    void change_text() {
        switch (page_number) {
            case 1:
                note_text.text = "This is the first page";
                break;
            case 2:
                note_text.text = "This is the second page";
                break;
            case 3:
                note_text.text = "This is the third page";
                break;
            default:
                break;
        }
    }

}
