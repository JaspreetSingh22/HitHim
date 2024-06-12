using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void Load(string Level)
    {
        SceneManager.LoadScene(Level);
   
    }
    public void Quit()
    {
        Debug.Log("Quit");
       Application.Quit();
    }
    public void NextLevel()
    {
       
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
    }
}
