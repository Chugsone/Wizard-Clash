using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winorlosetoafter : MonoBehaviour
{
    [SerializeField] private int waitTime = 5;

    public void OnFinish(string afterSceneName)
    {
        StartCoroutine(WaitForSeconds(afterSceneName));
    }

    IEnumerator WaitForSeconds(string afterSceneName)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(afterSceneName);

    }
}
