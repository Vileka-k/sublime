using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static int cheeseScore = 0;
    public Text score;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = gameManager.cheeseScore.ToString() ;
    }
}
