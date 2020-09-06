﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void ToggleMenu()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene(4);
    }

}
