using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    public void  startScen()
    {
        SceneManager.LoadScene("_Scene_1");
    }    
    public void  ExitGame()
    {
        Application.Quit();
    }  

}
