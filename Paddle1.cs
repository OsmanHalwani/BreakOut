using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    public float speed = 5f;
    private float input;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        input=Input.GetAxisRaw("Horizontal"); 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D bb = b.GetComponent<Rigidbody2D>();
            bb.AddForce(Vector3.up * 1000);

        }
    }
    private void FixedUpdate()
    {
       GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            

        }

    }
}
