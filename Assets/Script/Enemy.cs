using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
   
    {
        if (collision.gameObject.CompareTag("Ball"))
        {

            SceneManager.LoadScene("GameOver");
            Destroy(collision.gameObject);

        }
    }
}
