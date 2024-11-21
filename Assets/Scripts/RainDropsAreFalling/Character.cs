using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    public GameObject character;

    private void Update()
    {

        character.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, -2.6f);


        /*if (Input.mousePosition.x > 1)
        {

            character.transform.eulerAngles = new Vector3(
           character.transform.eulerAngles.x,
           character.transform.eulerAngles.y + 0,
           character.transform.eulerAngles.z
            );
        }

        if (Input.mousePosition.x < 1)
        {
            character.transform.eulerAngles = new Vector3(
           character.transform.eulerAngles.x,
           character.transform.eulerAngles.y + 180,
           character.transform.eulerAngles.z
            );
        }*/

    }

    

}
