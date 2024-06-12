using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    [SerializeField] private float maxX = 1.936f;
    [SerializeField] private float minX = -1.936f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= maxX && transform.position.x >= minX)
        {
            //To make player move left and right.
            transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));

        }
        else if (transform.position.x > maxX)
        {
            //To not let player go off the screen from right side.
            transform.position = new Vector3(maxX, transform.position.y, 0f);
        }
        else if (transform.position.x < minX)
        {
            //To not let player go off the screen from left side.
            transform.position = new Vector3(minX, transform.position.y, 0f);
        }
    }
}
