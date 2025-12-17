using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public OptionsManager OptionsManager { get; private set; }

    public AudioManager AudioManager { get; private set; }

    public DeckManager DeckManager { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeManagers();
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void InitializeManagers()
    {
        OptionsManager = FindFirstObjectByType<OptionsManager>();
        AudioManager = FindFirstObjectByType<AudioManager>();
        DeckManager = FindFirstObjectByType<DeckManager>();

        if (OptionsManager == null)
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/OptionsManager");
            if (prefab == null)
            {
                Debug.Log($"OptionsManager prefab not found")
            }
            else
            {
                InitializeManagers(prefab, transform.position, Quarternion.identity, transform);
                OptionsManager = GetComponentInChildren<OptionsManager>();
            }
        }
    }



    private void InitializeManagers()
    {
        OptionsManager = FindFirstObjectByType<OptionsManager>();
        AudioManager = FindFirstObjectByType<AudioManager>();
        DeckManager = FindFirstObjectByType<DeckManager>();

        if (AudioManager == null)
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/OptionsManager");
            if (prefab == null)
            {
                Debug.Log($"AudioManager prefab not found")
            }
            else
            {
                InitializeManagers(prefab, transform.position, Quarternion.identity, transform);
                OptionsManager = GetComponentInChildren<AudioManager>();
            }
        }
    }

    private void InitializeManagers()
    {
        OptionsManager = FindFirstObjectByType<OptionsManager>();
        AudioManager = FindFirstObjectByType<AudioManager>();
        DeckManager = FindFirstObjectByType<DeckManager>();

        if (DeckManager == null)
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/OptionsManager");
            if (prefab == null)
            {
                Debug.Log($"DeckManager prefab not found")
            }
            else
            {
                InitializeManagers(prefab, transform.position, Quarternion.identity, transform);
                OptionsManager = GetComponentInChildren<DeckManager>();
            }
        }
    }
}
