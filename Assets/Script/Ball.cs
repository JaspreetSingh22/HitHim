using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float dist;
    Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {   
        yield return new WaitForSeconds(1.5f);
        rb = GetComponent<Rigidbody2D>();
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5, 5), -5);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dist = this.transform.position.x - collision.gameObject.transform.position.x;

        }
        if (dist > 0.25 )
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5 , 5);
            dist = 0;
        }
        else if (dist < -0.25)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 5);
            dist = 0;
        }
        else if (dist < 0.25 && dist > 0.10)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 5);
            dist = 0;
        }
        else if (dist > -0.25 && dist <-0.10)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 5);
            dist = 0;
        }
        if(rb.velocity.magnitude > 15)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, 15);
        }
    }

}
