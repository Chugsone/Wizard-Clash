using UnityEngine;
using UnityEngine.SceneManagement;

public class mappoint : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        Debug.Log("Map point clicked: " + gameObject.name);
        FindFirstObjectByType<mapplayer>().currentpoint = gameObject;
        SceneManager.LoadScene(sceneName);
    }














}