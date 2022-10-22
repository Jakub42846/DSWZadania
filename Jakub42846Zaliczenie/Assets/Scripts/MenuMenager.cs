using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuMenager : MonoBehaviour
{
    [SerializeField] private Button exitButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button startButton;

    [SerializeField] private Button settingsBackButton;
    [SerializeField] private Button creditsBackButton;

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject creditsMenu;

    [SerializeField] private string sceneName;
    void Start()
    {
        exitButton.onClick.AddListener(ExitApp);
        settingsButton.onClick.AddListener(ShowSettingsMenu);
        creditsButton.onClick.AddListener(ShowCreditsMenu);
        startButton.onClick.AddListener(StartGame);

        settingsBackButton.onClick.AddListener(HideSettingsMenu);
        creditsBackButton.onClick.AddListener(HideCreditsMenu);
    }

    void StartGame()
    {
        SceneLoadManager.Instance.LoadScene(sceneName);
    }
    void ExitApp()
    {
        Application.Quit();
    }
    void ShowSettingsMenu()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    void ShowCreditsMenu()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }
    
    void HideSettingsMenu()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    void HideCreditsMenu()
    {
        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }
}
