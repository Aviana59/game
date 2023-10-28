using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingPage : MonoBehaviour
{
    public Image LoadingFill;

    void Start(){
        StartCoroutine(Loading());
    }

    IEnumerator Loading(){
        AsyncOperation loading = SceneManager.LoadSceneAsync("Main Menu");

        while(!loading.isDone){
            LoadingFill.fillAmount = loading.progress/0.9f;
            yield return null;
        }
    }
    
} 
