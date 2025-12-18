using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void OnStartClick()
    {
        Debug.Log("start");
        SceneManager.LoadScene("Map");
        
    }

    public void OnQuitClick()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void OnRetryClick()
    {
        SceneManager.LoadScene("Map");
    }

    public void OnShopClick()
    {
        SceneManager.LoadScene("shop");
    }

    public void OnContinueClick()
    {
        SceneManager.LoadScene("Map");
    }

    public void OnCreditsClick()
    {
        SceneManager.LoadScene("Credits");
    }
     
    }
