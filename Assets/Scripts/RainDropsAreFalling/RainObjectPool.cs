using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainObjectPool : MonoBehaviour
{
    public static RainObjectPool instance;


    [SerializeField] private GameObject rainDropsPrefab;
    private Queue<GameObject> raindropPool = new Queue<GameObject>();
    [SerializeField] private int rainDropPoolSize = 50;

    [SerializeField] private GameObject knifePrefab;
    private Queue<GameObject> knifePool = new Queue<GameObject>();
    [SerializeField] private int knifePoolSize = 50;

    [SerializeField] private GameObject bombPrefab;
    private Queue<GameObject> bombPool = new Queue<GameObject>();
    [SerializeField] private int bombPoolSize = 50;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void Start()
    {
        for (int i = 0; i < rainDropPoolSize; i++)
        {
            GameObject rain = Instantiate(rainDropsPrefab);
            raindropPool.Enqueue(rain);
            rain.SetActive(false);
            rain.transform.SetParent(GameObject.FindGameObjectWithTag("RainDropSpawner").transform, true);
            //rain.transform.localPosition = new Vector3(1, 1, 1f);
            rain.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        for (int i = 0; i < knifePoolSize; i++)
        {
            GameObject knife = Instantiate(knifePrefab);
            knifePool.Enqueue(knife);
            knife.SetActive(false);
            knife.transform.SetParent(GameObject.FindGameObjectWithTag("RainDropSpawner").transform, true);
            //rain.transform.localPosition = new Vector3(1, 1, 1f);
            knife.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        }

        for (int i = 0; i < bombPoolSize; i++)
        {
            GameObject bomb = Instantiate(bombPrefab);
            bombPool.Enqueue(bomb);
            bomb.SetActive(false);
            bomb.transform.SetParent(GameObject.FindGameObjectWithTag("RainDropSpawner").transform, true);
            //rain.transform.localPosition = new Vector3(1, 1, 1f);
            bomb.transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }



    public GameObject GetRainFromPool()
    {
        if (raindropPool.Count > 0)
        {
            GameObject rain = raindropPool.Dequeue();
            rain.SetActive(true);
            return rain;
        }
        else
        {
            GameObject rain = Instantiate(rainDropsPrefab);
            return rain;

        }
    }

    public void ReturnRainFromPool(GameObject rain)
    {
        raindropPool.Enqueue(rain);
        rain.SetActive(false);
    }



    public GameObject GetKnifeFromPool()
    {
        if (knifePool.Count > 0)
        {
            GameObject knife = knifePool.Dequeue();
            knife.SetActive(true);
            return knife;
        }
        else
        {
            GameObject rain = Instantiate(knifePrefab);
            return rain;

        }
    }

    public void ReturnKnifeFromPool(GameObject knife)
    {
        knifePool.Enqueue(knife);
        knife.SetActive(false);
    }


    public GameObject GetBombFromPool()
    {
        if (bombPool.Count > 0)
        {
            GameObject bomb = bombPool.Dequeue();
            bomb.SetActive(true);
            return bomb;
        }
        else
        {
            GameObject rain = Instantiate(bombPrefab);
            return rain;

        }
    }

    public void ReturnBombFromPool(GameObject bomb)
    {
        bombPool.Enqueue(bomb);
        bomb.SetActive(false);
    }
}
