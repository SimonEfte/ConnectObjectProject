using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieSpeedMove : MonoBehaviour
{
    public float boostSpeed;
    public Rigidbody2D rigidbody2d;
   

   

    public void Start()
    {
       // gameObject.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
    }

    void Update()
    {
        

            boostSpeed = 1;
            rigidbody2d.AddForce(-transform.right * boostSpeed * 0.3f);

       

            if (SwitchDie.spawnerNumber == 1) { }

       


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (SwitchDie.spawnerNumber == 1) {

            if (collision.gameObject.tag == "DIE1")
            {
                SwitchDie.scoreAmount += 1;
                ObjectPooling.instance.ReturnDieFromPool(gameObject);
            }

            if (collision.gameObject.tag == "DIE2" || collision.gameObject.tag == "DIE3" || collision.gameObject.tag == "DIE4"
            || collision.gameObject.tag == "DIE5" || collision.gameObject.tag == "DIE6")
            { ObjectPooling.instance.ReturnDieFromPool(gameObject); SwitchDie.triggerOnce = true; SwitchDie.lifes -= 1; }
        }

        
        if (SwitchDie.spawnerNumber == 2)
        {

            if (collision.gameObject.tag == "DIE2")
            {
                SwitchDie.scoreAmount += 1;
                ObjectPooling.instance.ReturnDieFromPool2(gameObject);
            }

            if (collision.gameObject.tag == "DIE1" || collision.gameObject.tag == "DIE3" || collision.gameObject.tag == "DIE4"
           || collision.gameObject.tag == "DIE5" || collision.gameObject.tag == "DIE6")
            { ObjectPooling.instance.ReturnDieFromPool2(gameObject); SwitchDie.triggerOnce = true; SwitchDie.lifes -= 1; }
        }


        if (SwitchDie.spawnerNumber == 3)
        {

            if (collision.gameObject.tag == "DIE3")
            {
                SwitchDie.scoreAmount += 1;
                ObjectPooling.instance.ReturnDieFromPool3(gameObject);
            }

            if (collision.gameObject.tag == "DIE1" || collision.gameObject.tag == "DIE2" || collision.gameObject.tag == "DIE4"
           || collision.gameObject.tag == "DIE5" || collision.gameObject.tag == "DIE6")
            { ObjectPooling.instance.ReturnDieFromPool3(gameObject); SwitchDie.triggerOnce = true; SwitchDie.lifes -= 1; }
        }

        if (SwitchDie.spawnerNumber == 4)
        {

            if (collision.gameObject.tag == "DIE4")
            {
                SwitchDie.scoreAmount += 1;
                ObjectPooling.instance.ReturnDieFromPool4(gameObject);
            }

            if (collision.gameObject.tag == "DIE1" || collision.gameObject.tag == "DIE2" || collision.gameObject.tag == "DIE3"
                || collision.gameObject.tag == "DIE5" || collision.gameObject.tag == "DIE6")
            { ObjectPooling.instance.ReturnDieFromPool4(gameObject); SwitchDie.triggerOnce = true; SwitchDie.lifes -= 1; }

        }


        if (SwitchDie.spawnerNumber == 5)
        {

            if (collision.gameObject.tag == "DIE5")
            {
                SwitchDie.scoreAmount += 1;
                ObjectPooling.instance.ReturnDieFromPool5(gameObject);
            }

            if (collision.gameObject.tag == "DIE1" || collision.gameObject.tag == "DIE2" || collision.gameObject.tag == "DIE3"
           || collision.gameObject.tag == "DIE4" || collision.gameObject.tag == "DIE6")
            { ObjectPooling.instance.ReturnDieFromPool5(gameObject); SwitchDie.triggerOnce = true; SwitchDie.lifes -= 1; }
        }



        if (SwitchDie.spawnerNumber == 6)
        {

            if (collision.gameObject.tag == "DIE6")
            {
                SwitchDie.scoreAmount += 1;
                ObjectPooling.instance.ReturnDieFromPool6(gameObject);
            }

            if (collision.gameObject.tag == "DIE1" || collision.gameObject.tag == "DIE2" || collision.gameObject.tag == "DIE3"
           || collision.gameObject.tag == "DIE4" || collision.gameObject.tag == "DIE5")
            { ObjectPooling.instance.ReturnDieFromPool6(gameObject); SwitchDie.triggerOnce = true; SwitchDie.lifes -= 1;  }
        }
    }

}
