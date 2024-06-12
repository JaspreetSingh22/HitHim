using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainEnemy : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D Collider2D;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Collider2D = GetComponent<BoxCollider2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.enabled = false;
        Collider2D.enabled = false;
        StartCoroutine(Finish());
    }
    IEnumerator Finish()
    {
      
        yield return new WaitForSeconds(2);
        if (PlayerPrefs.GetInt("Level") < 3)
        {
            SceneManager.LoadScene("Win");
            Destroy(gameObject);
        }
        else if (PlayerPrefs.GetInt("Level") == 3)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level")+1);
        }
    }
}
