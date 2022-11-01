using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int maxPoints = 8;
    public int currentPoints;

    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject player;

    [SerializeField] private string sceneName;

    [SerializeField] private GameObject winScreen;
    [SerializeField] private Button reloadButton;




    public static GameController Instance;
    private void Awake()

    {
        sceneName = SceneManager.GetActiveScene().name;
        reloadButton.onClick.AddListener(ReloadGame);
        Instance = this;
    }

    void ReloadGame()
    {
        SceneLoadManager.Instance.LoadScene(sceneName);
    }
    public void AddPoints(int points)
    {
        currentPoints += points;
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText("{0}/{1}",currentPoints, maxPoints);
        if (currentPoints==maxPoints)
        {
            winScreen.SetActive(true);
            player.SetActive(false);
        }
    }
}
