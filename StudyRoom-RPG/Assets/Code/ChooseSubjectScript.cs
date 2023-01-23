using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChooseSubjectScript : MonoBehaviour
{

    public Button next_b;
    public VerticalLayoutGroup selection_group;
    List<Button> subjects = new List<Button>();
    // Start is called before the first frame update
    void Start()
    {
        next_b.interactable = false;
        for (int i=0; i<selection_group.transform.childCount; i++) {
            Button button = selection_group.transform.GetChild(i).gameObject.GetComponent<Button>();
            subjects.Add(button);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void onSubjectSelection() {
        GameObject selected_object = EventSystem.current.currentSelectedGameObject;
        if (selected_object!=null && subjects.Contains(selected_object.GetComponent<Button>())) {
            next_b.interactable = true;
        }
        else {
            next_b.interactable = false;
        }
    }

}
