using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMechanics : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            RainObjectPool.instance.ReturnKnifeFromPool(gameObject);
            Raindrops.score -= 0;
        }


        if (collision.gameObject.tag == "RainCharacter")
        {
            RainObjectPool.instance.ReturnKnifeFromPool(gameObject);
            Raindrops.score -= 10;
        }
    }
}
