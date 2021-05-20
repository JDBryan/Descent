using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour {
    [SerializeField] private Button continueButton;
    [SerializeField] private Button loadGameButton;
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button quitButton;

    void Start() {
        continueButton.onClick.AddListener(LoadGame);
        loadGameButton.onClick.AddListener(LoadGame);
        newGameButton.onClick.AddListener(NewGame);
        quitButton.onClick.AddListener(Exit);
    }

    void LoadGame() {
        SceneManager.LoadScene("GameScene");
    }

    void NewGame() {
        SceneManager.LoadScene("GameScene");
    }

    void Exit() {
        Debug.Log("quitting");
        Application.Quit();
    }
}