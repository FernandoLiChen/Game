using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void PlayAgain(){
        SceneManager.LoadSceneAsync(sceneName: "SampleScene");

        Time.timeScale= 1;
    }
}
