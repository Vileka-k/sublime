using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soilGenerator : MonoBehaviour
{
    public GameObject soil; 
    public int spawnPoint;
    public float Timer = 0;
    GameObject soilClone;

    // Start is called before the first frame update
    void Start()
    {
        Timer = Random.Range(15f, 30.0f);
        if (spawnPoint==0){
            transform.rotation = Quaternion.Euler(0,0,0);
        }

        if (spawnPoint==1){
            transform.rotation = Quaternion.Euler(0,0,90);
        }

        if (spawnPoint==2){
            transform.rotation = Quaternion.Euler(0,0,180);
        }

        if (spawnPoint==3){
            transform.rotation = Quaternion.Euler(0,0,270);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            soilClone = Instantiate(soil, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation) as GameObject;
            Timer = Random.Range(15f, 30.0f);
        }
    }
}
