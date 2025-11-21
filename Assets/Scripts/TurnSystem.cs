using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public int yourTurn;
    public int isOpponentTurn;
    public Text turnText;

<<<<<<< HEAD
    public static bool startTurn;


=======
    
>>>>>>> bf9bb58a0fdd549ba0658978099abec189e1f0e0
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isYourTurn = true;
        yourTurn = 1;
        isOpponentTurn = 0;
<<<<<<< HEAD

        startTurn = false;

=======
>>>>>>> bf9bb58a0fdd549ba0658978099abec189e1f0e0
    }

    // Update is called once per frame
    void Update()
    {
        if(isYourTurn == true)
        {
            turnText.text = "Your Turn";
        }
        else
        {
            turnText.text = "Opponent's Turn";
        }
    }

    public void EndTurn()
    {
        isYourTurn = false;
        isOpponentTurn += 1;
    }

    public void EndOpponentTurn()
    {
        isYourTurn = true;
        yourTurn += 1;
<<<<<<< HEAD

        startTurn = true;
=======
>>>>>>> bf9bb58a0fdd549ba0658978099abec189e1f0e0
    }

}
