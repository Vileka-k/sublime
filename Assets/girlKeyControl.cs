using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlKeyControl : MonoBehaviour
{

    Rigidbody rb; 
    public bool movechecker = true;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (movechecker == true){
            float x = Input.GetAxisRaw("Horizontal"); 
            float moveBy = x * speed; 
            rb.velocity = new Vector2(moveBy, rb.velocity.y); 
        }
    }
}
