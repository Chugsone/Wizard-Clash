using UnityEngine;
using System.Collections.Generic;


public class Cards : MonoBehaviour
{
    //[SerializeField] private List<GameObject> _cardObjects = new List<GameObject>();



    [SerializeField] private List<int> _cardList;
    public List<int> CardList                
    {
        get { 
            return _cardList; 
            }
        set {
            if (_cardList.Count < 3)
            {

                _cardList.Add(value);
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
