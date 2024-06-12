using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public float FieldOfImpact;
    public float Power;
    public LayerMask LayerToHit;
    // Start is called before the first frame update
    void Start()
    { 
       Destroy(gameObject, 1.5f);

    }

    // Update is called once per frame
    void Update()
    {
      Collider2D[] obejcts =   Physics2D.OverlapCircleAll(transform.position, FieldOfImpact , LayerToHit);
        foreach(Collider2D obj in obejcts)
        {
            Vector2 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(direction * Power);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, FieldOfImpact);
    }
}
