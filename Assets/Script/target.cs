using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class target : MonoBehaviour
{
    public float speed=1f;
    public int score=0;
    public Transform leftPoint;
    public Transform rightPoint;
    public Text scoreUI;
    bool movingRight = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreUI.text = "SCORE:0";
        //rb.AddForce(transform.up * 30f, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= leftPoint.position.x)
        {
            movingRight = true;
        }
        if (transform.position.x >= rightPoint.position.x)
        {
            movingRight = false;

        }
    }
    private void FixedUpdate()
    {
        if (movingRight)
        {
            rb.MovePosition(rb.position + new Vector2(rightPoint.position.x + speed, 0f) * Time.fixedDeltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + new Vector2(leftPoint.position.x - speed, 0f) * Time.fixedDeltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dart")
        {
            score++;
            scoreUI.text = "SCORE:" + score.ToString();
            speed += 0.25f;
            Destroy(collision.gameObject);
        }
    }
}
