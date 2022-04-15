using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseCreator : MonoBehaviour
{
    public GameObject cheese; 
    public float Timer = 0;
    GameObject cheeseClone;

    // Start is called before the first frame update
    void Start()
    {
        Timer = Random.Range(5f, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            cheeseClone = Instantiate(cheese, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation) as GameObject;
            Timer = Random.Range(5f, 15.0f);
        }
    }
}
