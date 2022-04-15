using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringCreator : MonoBehaviour
{

    public GameObject ring; 
    public float Timer = 2;
    GameObject ringClone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            ringClone = Instantiate(ring, new Vector3(-0.2263f, 7.1f, 139f), transform.rotation) as GameObject;
            Timer = 4.5f;
        }
    }
}
