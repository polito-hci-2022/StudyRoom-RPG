using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {
    private const string WIN_ANIM_STATE_HIDE_TRIGGER = "hide";
    private const string WIN_ANIM_STATE_SHOW_TRIGGER = "show";
    private static readonly int WIN_SHOW_STATE = Animator.StringToHash(WIN_ANIM_STATE_SHOW_TRIGGER);
    private static readonly int WIN_HIDE_STATE = Animator.StringToHash(WIN_ANIM_STATE_HIDE_TRIGGER);

    private int _currentState = WIN_HIDE_STATE;

    [SerializeField] private Animator _winAnimator;
    [SerializeField] private TextMeshProUGUI _winnerText;
    [SerializeField] private Button _continueBtn;
    [SerializeField] private TextMeshProUGUI XTurn, OTurn;

    void Start() {
        _continueBtn.onClick.AddListener(GameManager.Instance.Board.Reset);
        GameManager.Instance.OnGameEnd += OnGameEnd;
        GameManager.Instance.OTurn = OTurn;
        GameManager.Instance.XTurn = XTurn;
    }

    private void OnGameEnd(bool end, int winType) {
        var state = end ? WIN_SHOW_STATE : WIN_HIDE_STATE;
        Debug.Log($"Game end {end} state {state} currentState {_currentState}");
        if (state == _currentState) {
            return;
        }

        if (end) {
            if (winType < 0) {
                _winnerText.SetText("No one");
            }
            else {
                _winnerText.SetText(winType == 0 ? "You" : "Person 1");
            }
        }
        XTurn.gameObject.SetActive(true);
        _winAnimator.SetTrigger(state);
        _currentState = state;
    }
}