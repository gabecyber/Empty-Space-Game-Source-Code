using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOuter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

        

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") {

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "EnemyBullet") {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
