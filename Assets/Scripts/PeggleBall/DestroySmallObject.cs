using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySmallObject : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BasketBall")
        {
            gameObject.SetActive(false);
        }
    }
}
