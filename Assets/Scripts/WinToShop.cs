using UnityEngine;
using UnityEngine.SceneManagement;

public class WinToShop : MonoBehaviour
{
    public void OnStartClick()
    {
        Debug.Log("start");
        SceneManager.LoadScene("shop");

    }

    public void OnQuitClick()
    {
        SceneManager.LoadScene("shop");
    }
}
