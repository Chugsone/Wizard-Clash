using UnityEngine;

public class mapplayer : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    public GameObject pointC;
    public GameObject pointD;
    public GameObject pointE;
    public GameObject currentpoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentpoint.transform.position;

    }
}
