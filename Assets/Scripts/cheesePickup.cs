using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cheesePickup : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<audioManager>().Play("cheese");
            gameManager.cheeseScore += 1;
            Debug.Log(gameManager.cheeseScore);
            Destroy(gameObject);
        }
    }
}
