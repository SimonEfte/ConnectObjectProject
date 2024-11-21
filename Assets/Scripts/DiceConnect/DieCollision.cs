using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCollision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Die1Coll")
        {
           // SwitchDie.spawnerNumber = 0;
        }
    }
}
