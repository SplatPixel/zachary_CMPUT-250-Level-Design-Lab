using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadManager : MonoBehaviour
{
    
    public TopDownPlayerBehaviour player;
    public string something;
    // Start is called before the first frame update
    void Awake()
    {
        TopDownUITimeBehaviour timescript = Object.FindObjectOfType<TopDownUITimeBehaviour>();
        if (SceneManager.GetActiveScene().name == "Intro Level"){
            PlayerPrefs.SetString("timeStringVariable", "0");
        }
        string timeStringVariable = PlayerPrefs.GetString("timeStringVariable");
        //PlayerPrefs.SetString("timeStringVariable", timescript.time.ToString());
        timescript.time = float.Parse(timeStringVariable);



        something = PlayerPrefs.GetString("currentLevel");
        Debug.Log("load man: "+ PlayerPrefs.GetString("currentLevel"));
    }
    void Update(){
        if (something != PlayerPrefs.GetString("currentLevel")){
            PlayerPrefs.SetString("currentLevel", something);
            Debug.Log(PlayerPrefs.GetString("currentLevel"));
        }
        //Debug.Log("load man: "+ PlayerPrefs.GetString("currentLevel"));
    }
}
