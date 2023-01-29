using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ZoomManagementScript : MonoBehaviour
{
    Text zoom_percentage_text;
    Button zoom_out, zoom_in;
    int zoom_percentage = 100;
    public Text note_text;

    // Start is called before the first frame update
    void Start()
    {
        zoom_percentage_text = gameObject.transform.GetChild(0).GetComponent<Text>();
        zoom_out = gameObject.transform.GetChild(1).GetComponent<Button>();
        zoom_in = gameObject.transform.GetChild(2).GetComponent<Button>();
        zoom_percentage_text.text = "Zoom: " + zoom_percentage + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ZoomIn () {
        zoom_percentage += 50;
        zoom_percentage_text.text = "Zoom: " + zoom_percentage + "%";
        if (zoom_percentage == 150) {
            zoom_in.interactable = false;
        }
        if (zoom_percentage != 50) {
            zoom_out.interactable = true;
        }
        change_text();
    }

    public void ZoomOut() {
        zoom_percentage -= 50;
        zoom_percentage_text.text = "Zoom: " + zoom_percentage + "%";
        if (zoom_percentage == 50) {
            zoom_out.interactable = false;
        }
        if (zoom_percentage != 150) {
            zoom_in.interactable = true;
        }
        change_text();
    }

    void change_text() {
        switch (zoom_percentage) {
            case 50:
                note_text.fontSize = 25;
                break;
            case 100:
                note_text.fontSize = 50;
                break;
            case 150:
                note_text.fontSize = 75;
                break;
            default:
                break;
        }
    }

}
