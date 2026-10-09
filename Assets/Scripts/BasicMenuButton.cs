using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;//

public class BasicMenuButton : MonoBehaviour
{
    
    public void StartGame(){
        Debug.Log("start" + PlayerPrefs.GetString("currentLevel"));
        PlayerPrefs.SetString("currentLevel", "Intro Level");
        PlayerPrefs.Save();
        SceneManager.LoadScene(PlayerPrefs.GetString("currentLevel"));//
    }
}
