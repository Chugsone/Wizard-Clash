using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void OnStartClick()
    {
        Debug.Log("start");
        SceneManager.LoadScene("Deklin");
        
    }

    public void OnQuitClick()
    {
        SceneManager.LoadScene("Deklin");
    }

    public void OnRetryClick()
    {
        SceneManager.LoadScene("test");
    }

    public void OnShopClick()
    {
        SceneManager.LoadScene("shop");
    }

    public void OnContinueClick()
    {
        SceneManager.LoadScene("Warren");
    }
}
