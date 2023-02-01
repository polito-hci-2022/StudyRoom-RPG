using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GameConfirmationModalScript : MonoBehaviour
{
    string gamename = "Tic Tac Toe";

    void OnEnable()
    {
        gameObject.transform.GetChild(2).GetComponent<Text>().text = "Do you want to play " + gamename + "?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetChosenGame(Text gametext) {
        this.gamename = gametext.text;
    }

    public string GetChosenGame() {
        return gamename;
    }
}

