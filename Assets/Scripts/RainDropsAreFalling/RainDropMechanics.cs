using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDropMechanics : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            RainObjectPool.instance.ReturnRainFromPool(gameObject);
            Raindrops.score -= 1;
        }


        if (collision.gameObject.tag == "RainCharacter")
        {
            RainObjectPool.instance.ReturnRainFromPool(gameObject);
            Raindrops.score += 2;
        }
    }
}
