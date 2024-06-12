using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject EffPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(EffPrefab, collision.transform.position , Quaternion.identity);
        Destroy(gameObject);
    }
    
}
