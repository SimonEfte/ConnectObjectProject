using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBasketball : MonoBehaviour
{
    public float speed = 2.0f; 
    public float distance = 2.0f; 
    private Vector3 initialPosition; 
    private bool isMoving = true; 
    private bool isMovingRight = true;

    void Start()
    {
        gameObject.SetActive(true);
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        initialPosition = transform.position;
    }

    void Update()
    {
        if (isMoving)
        {
            float newPosition = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
            transform.position = new Vector3(initialPosition.x + newPosition, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= initialPosition.x + distance && isMovingRight)
        {
            isMovingRight = false;
        }
        else if (transform.position.x <= initialPosition.x - distance && !isMovingRight)
        {
            isMovingRight = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.5f;
            isMoving = false;
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor") {

            gameObject.SetActive(false);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            gameObject.transform.localPosition = new Vector3(0, 476, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            gameObject.SetActive(true);
            isMoving = true;
        }
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
       
    }

}
