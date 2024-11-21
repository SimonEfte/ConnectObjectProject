using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwitchDie : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public GameObject die1;
    public GameObject die2;
    public GameObject die3;
    public GameObject die4;
    public GameObject die5;
    public GameObject die6;

    public static int lifes;
    public static bool triggerOnce;

    public TextMeshProUGUI score;
    public static int scoreAmount;
    public bool spawnDie;
    public GameObject youLoose;
    public GameObject playButton;
    public static bool isPlaying;
    public TextMeshProUGUI youScored;

    private void Start()
    {
        isPlaying = false;
        triggerOnce = true;
        lifes = 3;
        spawnDie = true;
    }

    public void PlayGame()
    {
        isPlaying = true;
        playButton.SetActive(false);
    }

    public void Update()
    {

        score.text = "SCORE: " + scoreAmount;

        if (SwitchDie.isPlaying == true) {

            if (spawnDie == true) { StartCoroutine(spawnRandomDie()); spawnDie = false; }

            if (Input.GetMouseButtonDown(0))
            {
                ClickDie();
            }

            if (lifes == 2 && triggerOnce == true)
            {
                triggerOnce = false;
                heart1.GetComponent<Image>().color = Color.red;
            }
            if (lifes == 1 && triggerOnce == true)
            {
                triggerOnce = false;
                heart2.GetComponent<Image>().color = Color.red;
            }
            if (lifes == 0 && triggerOnce == true)
            {
                if(scoreAmount == 1) { youScored.text = "YOU SCORED: " + scoreAmount + " POINT"; }
                if (scoreAmount == 0 || scoreAmount >1) { youScored.text = "YOU SCORED: " + scoreAmount + " POINTS"; }

                scoreAmount = 0;
                isPlaying = false;
                StopAllCoroutines();
                youLoose.SetActive(true);
                triggerOnce = false;
                heart3.GetComponent<Image>().color = Color.red;
                lifes = 3;
            }

        }

        


    }

    public void ClickDie()
    {
        if (die1.gameObject.activeInHierarchy) { die2.SetActive(true); die1.SetActive(false); }
        else if (die2.gameObject.activeInHierarchy) { die3.SetActive(true); die2.SetActive(false); }
        else if(die3.gameObject.activeInHierarchy) { die4.SetActive(true); die3.SetActive(false); }
        else if(die4.gameObject.activeInHierarchy) { die5.SetActive(true); die4.SetActive(false); }
        else if(die5.gameObject.activeInHierarchy) { die6.SetActive(true); die5.SetActive(false); }
        else if(die6.gameObject.activeInHierarchy) { die1.SetActive(true); die6.SetActive(false); }

    }

    public static int spawnerNumber;

    IEnumerator spawnRandomDie()
    {
        yield return new WaitForSeconds(2.45f);
        int random = Random.Range(1, 7);
        if(random == 1) { spawnerNumber = 1; GameObject die1 = ObjectPooling.instance.GetDiceFromPool();
            die1.transform.localPosition = new Vector3(0, -0, 0);
            die1.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
        }
        if (random == 2) { spawnerNumber = 2; GameObject die2 = ObjectPooling.instance.GetDiceFromPool2(); die2.transform.position = new Vector3(555, -25, 0);
            die2.transform.localPosition = new Vector3(0, -0, 0);
            die2.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
        }
        if (random == 3) { spawnerNumber = 3; GameObject die3 = ObjectPooling.instance.GetDiceFromPool3(); die3.transform.position = new Vector3(555, -25, 0);
            die3.transform.localPosition = new Vector3(0, -0, 0);
            die3.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
        }
        if (random == 4) { spawnerNumber = 4; GameObject die4 = ObjectPooling.instance.GetDiceFromPool4(); die4.transform.position = new Vector3(555, -25, 0);

            die4.transform.localPosition = new Vector3(0, -0, 0);
            die4.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
        }
        if (random == 5) { spawnerNumber = 5; GameObject die5 = ObjectPooling.instance.GetDiceFromPool5(); die5.transform.position = new Vector3(555, -25, 0);

            die5.transform.localPosition = new Vector3(0, -0, 0);
            die5.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
        }
        if (random == 6) { spawnerNumber = 6; GameObject die6 = ObjectPooling.instance.GetDiceFromPool6(); die6.transform.position = new Vector3(555, -25, 0);

            die6.transform.localPosition = new Vector3(0, -0, 0);
            die6.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
        }
        spawnDie = true;

    }

    public void AddATestMedhos()
    {
        Debug.Log("Yello");
    }
    
    public void playAgain()
    {
        heart1.GetComponent<Image>().color = Color.green;
        heart2.GetComponent<Image>().color = Color.green;
        heart3.GetComponent<Image>().color = Color.green;
        spawnDie = true;
        isPlaying = true;
        youLoose.SetActive(false);
    }

    public void doNotPlayAgain()
    {
        youLoose.SetActive(false);
    }
    

}
