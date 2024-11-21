using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    public static float speed;
    public Vector3 target = new Vector3(0, 0, 0);
    

    public void Start()
    {
        speed = 1.9f;
    }

   

    void Update()
    {
       

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SlimeGetObject")
        {

            SlimeObjectPool.instance.ReturnSlimeFromPool(gameObject);
        }


        if(collision.gameObject.tag == "ClickObject")
        {
            SlimeSpawner.squishCount += 1;
            SlimeObjectPool.instance.ReturnSlimeFromPool(gameObject);

            GameObject squish = SlimeObjectPool.instance.GetSquishFromPool();
            squish.transform.position = gameObject.transform.position;


        }
    }
    

}
