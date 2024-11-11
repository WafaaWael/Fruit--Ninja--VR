using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject LoadingScreen;
    [SerializeField] Image loadingBarFill;


    public void LoadScene(int SceneID)
    {
        Time.timeScale = 1;
        StartCoroutine(LoadSceneAsync(SceneID));

    }

    IEnumerator LoadSceneAsync(int SceneId)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(SceneId);
        LoadingScreen.SetActive(true);
        while (!asyncOperation.isDone)
        {
            float progressValue = Mathf.Clamp01(asyncOperation.progress / 0.9f);

            loadingBarFill.fillAmount = progressValue;

            yield return null;
        }





    }

}
