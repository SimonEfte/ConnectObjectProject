using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;

    [SerializeField] private GameObject die1;
    private Queue<GameObject> dicePool1 = new Queue<GameObject>();
    [SerializeField] private int dicePoolSize1 = 3;

    [SerializeField] private GameObject die2;
    private Queue<GameObject> dicePool2 = new Queue<GameObject>();
    [SerializeField] private int dicePoolSize2 = 3;

    [SerializeField] private GameObject die3;
    private Queue<GameObject> dicePool3 = new Queue<GameObject>();
    [SerializeField] private int dicePoolSize3 = 3;

    [SerializeField] private GameObject die4;
    private Queue<GameObject> dicePool4 = new Queue<GameObject>();
    [SerializeField] private int dicePoolSize4 = 3;

    [SerializeField] private GameObject die5;
    private Queue<GameObject> dicePool5 = new Queue<GameObject>();
    [SerializeField] private int dicePoolSize5 = 3;

    [SerializeField] private GameObject die6;
    private Queue<GameObject> dicePool6 = new Queue<GameObject>();
    [SerializeField] private int dicePoolSize6 = 3;


    [SerializeField] private GameObject rainDropsPrefab;
    private Queue<GameObject> raindropPool = new Queue<GameObject>();
    [SerializeField] private int rainDropPoolSize = 50;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Start()
    {
        for (int i = 0; i < dicePoolSize1; i++)
        {
            GameObject die = Instantiate(die1);
            dicePool1.Enqueue(die);
            die.SetActive(false);
            die.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
            die.transform.localScale = new Vector3(1, 1, 1f);
        }

        for (int i = 0; i < dicePoolSize2; i++)
        {
            GameObject die = Instantiate(die2);
            dicePool2.Enqueue(die);
            die.SetActive(false);
            die.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
            die.transform.localScale = new Vector3(1, 1, 1f);
        }

        for (int i = 0; i < dicePoolSize3; i++)
        {
            GameObject die = Instantiate(die3);
            dicePool3.Enqueue(die);
            die.SetActive(false);
            die.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
            die.transform.localScale = new Vector3(1, 1, 1f);
        }

        for (int i = 0; i < dicePoolSize4; i++)
        {
            GameObject die = Instantiate(die4);
            dicePool4.Enqueue(die);
            die.SetActive(false);
            die.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
            die.transform.localScale = new Vector3(1, 1, 1f);
        }

        for (int i = 0; i < dicePoolSize5; i++)
        {
            GameObject die = Instantiate(die5);
            dicePool5.Enqueue(die);
            die.SetActive(false);
            die.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
            die.transform.localScale = new Vector3(1, 1, 1f);
        }

        for (int i = 0; i < dicePoolSize6; i++)
        {
            GameObject die = Instantiate(die6);
            dicePool6.Enqueue(die);
            die.SetActive(false);
            die.transform.SetParent(GameObject.FindGameObjectWithTag("dieParent").transform, true);
            die.transform.localScale = new Vector3(1, 1, 1f);
        }

        

    }

    #region dice
    public GameObject GetDiceFromPool()
    {
        if (dicePool1.Count > 0)
        {
            GameObject die = dicePool1.Dequeue();
            die.SetActive(true);
            return die;
        }
        else
        {
            GameObject die = Instantiate(die1);
            return die;

        }
    }

    public void ReturnDieFromPool(GameObject die)
    {
        dicePool1.Enqueue(die);
        die.SetActive(false);
    }


    public GameObject GetDiceFromPool2()
    {
        if (dicePool2.Count > 0)
        {
            GameObject die = dicePool2.Dequeue();
            die.SetActive(true);
            return die;
        }
        else
        {
            GameObject die = Instantiate(die2);
            return die;

        }
    }

    public void ReturnDieFromPool2(GameObject die)
    {
        dicePool2.Enqueue(die);
        die.SetActive(false);
    }


    public GameObject GetDiceFromPool3()
    {
        if (dicePool3.Count > 0)
        {
            GameObject die = dicePool3.Dequeue();
            die.SetActive(true);
            return die;
        }
        else
        {
            GameObject die = Instantiate(die3);
            return die;

        }
    }

    public void ReturnDieFromPool3(GameObject die)
    {
        dicePool3.Enqueue(die);
        die.SetActive(false);
    }


    public GameObject GetDiceFromPool4()
    {
        if (dicePool4.Count > 0)
        {
            GameObject die = dicePool4.Dequeue();
            die.SetActive(true);
            return die;
        }
        else
        {
            GameObject die = Instantiate(die4);
            return die;

        }
    }

    public void ReturnDieFromPool4(GameObject die)
    {
        dicePool4.Enqueue(die);
        die.SetActive(false);
    }


    public GameObject GetDiceFromPool5()
    {
        if (dicePool5.Count > 0)
        {
            GameObject die = dicePool5.Dequeue();
            die.SetActive(true);
            return die;
        }
        else
        {
            GameObject die = Instantiate(die5);
            return die;

        }
    }

    public void ReturnDieFromPool5(GameObject die)
    {
        dicePool5.Enqueue(die);
        die.SetActive(false);
    }


    public GameObject GetDiceFromPool6()
    {
        if (dicePool6.Count > 0)
        {
            GameObject die = dicePool6.Dequeue();
            die.SetActive(true);
            return die;
        }
        else
        {
            GameObject die = Instantiate(die6);
            return die;

        }
    }

    public void ReturnDieFromPool6(GameObject die)
    {
        dicePool6.Enqueue(die);
        die.SetActive(false);
    }

    #endregion

    
}

