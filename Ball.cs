using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    AudioSource tick;
    public static float speed=8f;
        
    bool boolean = false;
     //  public GameObject ballPreFab;

    // Start is called before the first frame update
        void Start()
        {
       
        Respawn();
        tick = GetComponent<AudioSource>();
        gameObject.transform.position = Vector3.zero;
    }

        // Update is called once per frame
        void Update()
        {
           GetComponent<Rigidbody2D>().velocity = speed * GetComponent<Rigidbody2D>().velocity.normalized;
        }
        public void Respawn()
        {
           // transform.position =Vector2.zero;
            gameObject.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;

        }
   
        private void OnCollisionEnter2D(Collision2D other)
        {
        if (other.gameObject.CompareTag("Respawn") &&( boolean == false))
        {
            boolean = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Debug.Log("hit");
            Debug.Log(boolean);
          
            Respawn();
            //boolean = false;
           
           

        }

        if (other.gameObject.CompareTag("playSound"))
        {
            tick.Play();
        }
           

        }
   
    private void OnCollisionExit2D(Collision2D collision)
    {
        if((collision.gameObject.CompareTag("Respawn")) && boolean == true)
        {
            sc.lives -= 1;
            scEasy.lives -= 1;
            gameObject.transform.position = Vector3.zero;
     
            boolean = false; ;
        }
    }
    IEnumerator ExampleCoroutine()
        {
            //Print the time of when the function is first called.
            //Debug.Log("Started Coroutine at timestamp : " + Time.time);

            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(5);



        }


    }
