using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlimeSpawner : MonoBehaviour
{
    public static bool slimeIsSpawning;
    public static float waitTime;
    [Header("Sprites")]
    public Sprite[] sprites;
    public static int squishCount;
    public TextMeshProUGUI squishedAmountText;

    public void Start()
    {
        squishCount = 0;
        waitTime = 0.6f;
        slimeIsSpawning = true;
    }

    public void Update()
    {
        squishedAmountText.text = "SLIMES SQUISHED = " + squishCount;


        if (slimeIsSpawning == true) 
        {
            StartCoroutine(SpawnSlime());
            slimeIsSpawning = false;
        
        }
    }

    IEnumerator SpawnSlime()
    {
        int randomScreenPosition = Random.Range(1, 5);

        float randomXaxis = Random.Range(-9.1f, 9.1f);
        float randomYaxis = Random.Range(-5.1f, 5.1f);

        if(squishCount == 10) { waitTime = 0.55f; } if(squishCount == 15) { waitTime = 0.52f; } if(squishCount == 20) { waitTime = 0.5f; }
        if (squishCount == 30) { waitTime = 0.45f; }if (squishCount == 35) { waitTime = 0.40f; } if (squishCount == 40) { waitTime = 0.3f; }
        

        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];


        yield return new WaitForSeconds(waitTime);
        slimeIsSpawning = true;
        GameObject slime = SlimeObjectPool.instance.GetSlimeFromPool();
        //if (randomSprite == sprites[0]) { slime.GetComponent<Animation>().Play("SlimeAnim"); }

        slime.GetComponent<SpriteRenderer>().sprite = randomSprite;
        if (randomScreenPosition == 1) { slime.transform.position = new Vector2(10, randomYaxis); }
        if (randomScreenPosition == 2) { slime.transform.position = new Vector2(randomXaxis, 6); }
        if (randomScreenPosition == 3) { slime.transform.position = new Vector2(-10, randomYaxis); }
        if (randomScreenPosition == 4) { slime.transform.position = new Vector2(randomXaxis, -6); }


        

    }

}
