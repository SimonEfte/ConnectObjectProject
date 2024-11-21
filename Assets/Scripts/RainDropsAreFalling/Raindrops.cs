using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Raindrops : MonoBehaviour
{

    public bool isRainDropping;
    public TextMeshProUGUI scoreText;
    public static int score;
    public float waitForRainDrops;

    private void Start()
    {

        isRainDropping = true;
        waitForRainDrops = 1f;


    }


    public void Update()
    {


        if (score >= 400) { waitForRainDrops = 0.15f; }
        else if (score >= 300) { waitForRainDrops = 0.20f; }
        else if (score >= 200) { waitForRainDrops = 0.23f; }
        else if (score >= 150) { waitForRainDrops = 0.3f; }
        else if (score >= 100) { waitForRainDrops = 0.4f; }
        else if (score >= 80) { waitForRainDrops = 0.5f; }
        else if (score >= 70) { waitForRainDrops = 0.6f; }
        else if (score >= 50) { waitForRainDrops = 0.77f; }
        else if (score >= 30) { waitForRainDrops = 0.87f; }
        else if (score >= 20) { waitForRainDrops = 0.9f; }


        scoreText.text = "SCORE: " + score;

        if (isRainDropping == true)
        {
            StartCoroutine(waitForRain());
            isRainDropping = false;
        }
    }

    IEnumerator waitForRain()
    {
        int randomBomb = Random.Range(-1100, 1100);
        int randomKnife = Random.Range(-1100, 1100);
        int randomRain = Random.Range(-1100, 1100);
        int random = Random.Range(1, 9);
        int random2 = Random.Range(1, 13);
        yield return new WaitForSeconds(waitForRainDrops);
        GameObject rain = RainObjectPool.instance.GetRainFromPool();
        rain.transform.localPosition = new Vector2(randomRain, 0);

        if(random == 1)
        {
            GameObject knife = RainObjectPool.instance.GetKnifeFromPool();
            knife.transform.localPosition = new Vector2(randomKnife, 0);
        }

        if (random2 == 1)
        {
            GameObject bomb = RainObjectPool.instance.GetBombFromPool();
            bomb.transform.localPosition = new Vector2(randomBomb, 0);
        }

        isRainDropping = true;

    }
}
