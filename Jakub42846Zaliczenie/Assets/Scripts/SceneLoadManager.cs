using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private Slider progressBar;

    public static SceneLoadManager Instance;

    private void Awake()
        
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(LoadSceneCoroutine(scene));
    }

    private IEnumerator LoadSceneCoroutine(string scene)
    {
        canvas.SetActive(true);
        AsyncOperation op = SceneManager.LoadSceneAsync(scene);
        op.allowSceneActivation = false;
        while (!op.isDone)
        {
            progressBar.value = op.progress / 0.9f;
            if(op.progress >= 0.9f)
            {
                break;
            }
            yield return null;
        }
        op.allowSceneActivation = true;
        canvas.SetActive(false);
    }

}
