using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObjectSpawn : MonoBehaviour
{
    public Camera camera1;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(setClickInactive());
            
        }
    }

    IEnumerator setClickInactive()
    {
        GameObject click = SlimeObjectPool.instance.GetClickFromPool();

        click.transform.position = camera1.ScreenToWorldPoint(Input.mousePosition);
        //squish.transform.position.z = 2;

        yield return new WaitForSeconds(0.07f);
        SlimeObjectPool.instance.ReturnClickFromPool(click);



    }

}
