using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Livecal : MonoBehaviour
{
    public Text LiveText;
    
    // Update is called once per frame
    void Update()
    {
        LiveText.text = (PlayerPrefs.GetInt("Lives")+1).ToString(); 
    }
}
