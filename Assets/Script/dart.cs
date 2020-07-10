using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dart : MonoBehaviour
{
   // public float speed;
   // Rigidbody2D rb;
    //public GameObject shooter;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
      //  rb.velocity = Camera.main.transform.forward * 40 * Time.fixedDeltaTime;
         //rb.velocity = new Vector2(0f, speed * Time.fixedDeltaTime);
        //rb.velocity = new Vector2(transform.position.x * speed, transform.position.y * speed);
    }
}
