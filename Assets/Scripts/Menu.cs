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
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        continueButton.onClick.AddListener(LoadGame);
        loadGameButton.onClick.AddListener(LoadGame);
        newGameButton.onClick.AddListener(NewGame);
        quitButton.onClick.AddListener(Exit);
    }

    void LoadGame() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene("GameScene");
    }

    void NewGame() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene("GameScene");
    }

    void Exit() {
        Debug.Log("quitting");
        Application.Quit();
    }
}