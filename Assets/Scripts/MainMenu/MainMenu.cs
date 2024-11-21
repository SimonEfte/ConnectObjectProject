using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadDiceConnect()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadRainDrops()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadSlimeSquisher()
    {
        SceneManager.LoadScene(3);
    }
}
