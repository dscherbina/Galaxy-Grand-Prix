using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using KartGame.KartSystems;


public class LoadLobby : MonoBehaviour
{
    AsyncOperation asyncOperation;
    public Image LoadBar;
    public Text BarTxt;
    public int ScenID;
    void Start()
    {
        StartCoroutine(LoadSceneCore());
    }
    IEnumerator LoadSceneCore()
    {
        yield return new WaitForSeconds(1);
        asyncOperation = SceneManager.LoadSceneAsync(ScenID);
        while (!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.9f;
            LoadBar.fillAmount = progress;
            BarTxt.text = "Loading...      " + string.Format("{0:0}%", progress * 100f);
            yield return 0;
            
        }
        yield return new WaitForSeconds(2);
    }
}
