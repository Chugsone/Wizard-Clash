using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Deklin");
        
    }

    public void OnQuitClick()
    {
        SceneManager.LoadScene("Deklin");
    }
}
