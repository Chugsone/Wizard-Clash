using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winorlosetoafter : MonoBehaviour
{
    [SerializeField] private string afterSceneName;
    [SerializeField] private int waitTime = 5;

    public void OnFinish()
    {
        StartCoroutine(WaitForSeconds());
        SceneManager.LoadScene(afterSceneName);
    }

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
