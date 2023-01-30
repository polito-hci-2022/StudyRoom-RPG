using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameWaitScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(2).GetComponent<Text>().text = "Waiting for other players to join the game..." + '\n' + '\n' + "1/2";
        gameObject.transform.GetChild(4).GetComponent<Button>().interactable = false;
        Invoke("UpdatePlayerNum", 3);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void UpdatePlayerNum () {
        gameObject.transform.GetChild(2).GetComponent<Text>().text = "Waiting for other players to join the game..." + '\n' + '\n' + "2/2";
        gameObject.transform.GetChild(4).GetComponent<Button>().interactable = true;
    }
}
