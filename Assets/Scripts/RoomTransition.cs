using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomTransition : MonoBehaviour
{
    public string SceneToTransitionTo;

    // called when the cube hits the floor
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("worked: " + PlayerPrefs.GetString("currentLevel"));
        TopDownPlayerBehaviour player = col.gameObject.GetComponent<TopDownPlayerBehaviour>();
        if(player!=null){

            if(SceneToTransitionTo!=""){
                //Get Time 
                TopDownUITimeBehaviour timescript = Object.FindObjectOfType<TopDownUITimeBehaviour>();
                PlayerPrefs.SetString("timeStringVariable", timescript.time.ToString());


                Debug.Log("went to transition: " + PlayerPrefs.GetString("currentLevel"));
                if (PlayerPrefs.GetString("currentLevel") == "Intro Level"){
                    PlayerPrefs.SetString("currentLevel", "Practice Level");
                    SceneManager.LoadScene(SceneToTransitionTo);
                }
                if (PlayerPrefs.GetString("currentLevel") == "Practice Level"){
                    PlayerPrefs.SetString("currentLevel", "Challenge Level");
                    SceneManager.LoadScene(SceneToTransitionTo);
                }                
            }
        }
    }


}
