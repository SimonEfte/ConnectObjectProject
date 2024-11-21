using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeObjectPool : MonoBehaviour
{

    public static SlimeObjectPool instance;

    [SerializeField] private GameObject slimePrefab;
    private Queue<GameObject> slimePool = new Queue<GameObject>();
    [SerializeField] private int slimePoolSize = 30;

    [SerializeField] private GameObject clickObjectPrefab;
    private Queue<GameObject> clickPool = new Queue<GameObject>();
    [SerializeField] private int clickPoolSize = 30;

    [SerializeField] private GameObject squishPrefab;
    private Queue<GameObject> squishPool = new Queue<GameObject>();
    [SerializeField] private int squishPoolSize = 30;


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void Start()
    {
        for (int i = 0; i < slimePoolSize; i++)
        {
            GameObject slime = Instantiate(slimePrefab);
            slimePool.Enqueue(slime);
            slime.SetActive(false);
            //slime.transform.SetParent(GameObject.FindGameObjectWithTag("slimeSpawner").transform, true);
            slime.transform.localScale = new Vector3(0.17f, 0.17f, 0.17f);
        }


        for (int i = 0; i < clickPoolSize; i++)
        {
            GameObject click = Instantiate(clickObjectPrefab);
            clickPool.Enqueue(click);
            click.SetActive(false);
            click.transform.SetParent(GameObject.FindGameObjectWithTag("slimeSpawner").transform, true);
            click.transform.localScale = new Vector3(0.17f, 0.17f, 0.17f);
        }


        for (int i = 0; i < squishPoolSize; i++)
        {
            GameObject squish = Instantiate(squishPrefab);
            squishPool.Enqueue(squish);
            squish.SetActive(false);
            squish.transform.SetParent(GameObject.FindGameObjectWithTag("slimeSpawner").transform, true);
            squish.transform.localScale = new Vector3(1.17f, 1.17f, 1.17f);
        }
    }



    public GameObject GetSlimeFromPool()
    {
        if (slimePool.Count > 0)
        {
            GameObject slime = slimePool.Dequeue();
            slime.SetActive(true);
            return slime;
        }
        else
        {
            GameObject slime = Instantiate(slimePrefab);
            return slime;

        }
    }

    public void ReturnSlimeFromPool(GameObject slime)
    {
        slimePool.Enqueue(slime);
        slime.SetActive(false);
    }



    public GameObject GetClickFromPool()
    {
        if (clickPool.Count > 0)
        {
            GameObject click = clickPool.Dequeue();
            click.SetActive(true);
            return click;
        }
        else
        {
            GameObject click = Instantiate(clickObjectPrefab);
            return click;

        }
    }

    public void ReturnClickFromPool(GameObject click)
    {
        clickPool.Enqueue(click);
        click.SetActive(false);
    }


    public GameObject GetSquishFromPool()
    {
        if (squishPool.Count > 0)
        {
            GameObject squish = squishPool.Dequeue();
            squish.SetActive(true);
            return squish;
        }
        else
        {
            GameObject squish = Instantiate(squishPrefab);
            return squish;

        }
    }

    public void ReturnSquishFromPool(GameObject squish)
    {
        squishPool.Enqueue(squish);
        squish.SetActive(false);
    }
}

