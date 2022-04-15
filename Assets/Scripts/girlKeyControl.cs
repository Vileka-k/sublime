using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlKeyControl : MonoBehaviour
{
    [Header("Resource Objects")]
    public GameObject point0;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    
    public float[] pointVector0 = {0.01f, -0.36f, 0.41f};
    public float[] pointVector1 = {7.9f, 6.92f, 0.41f};
    public float[] pointVector2 = {0.12f, 14.96f, 0.41f};
    public float[] pointVector3 = {-7.87f, 6.98f, 0.41f};
    public float[] rotationXVals = {-13.05f, 0.00f, 0.41f, 0.0f};
    public float[] rotationZVals = {0f, 90.0f, 180.0f, 270.0f};

    private float secondX;
    private float secondY;
    private float secondZ;
    public float rotationX;
    public float rotationZ;

    public static int currentPoint = 0 ;
    public float movementSpeed;
    public float rotationSpeed = 5f;

    void Start(){
        FindObjectOfType<audioManager>().Play("bgmusic");
    }
    void Update()
    {

        if (currentPoint == 0){
            secondX = pointVector0[0];
            secondY = pointVector0[1];
            secondZ = pointVector0[2];

            rotationX = rotationXVals[0];
            rotationZ = rotationZVals[0];
        }

        if (currentPoint == 1){
            secondX = pointVector1[0];
            secondY = pointVector1[1];
            secondZ = pointVector1[2];

            rotationX = rotationXVals[1];
            rotationZ = rotationZVals[1];
        }

        if (currentPoint == 2){
            secondX = pointVector2[0];
            secondY = pointVector2[1];
            secondZ = pointVector2[2];

            rotationX = rotationXVals[2];
            rotationZ = rotationZVals[2];
        }

        if (currentPoint == 3){
            secondX = pointVector3[0];
            secondY = pointVector3[1];
            secondZ = pointVector3[2];

            rotationX = rotationXVals[3];
            rotationZ = rotationZVals[3];
        }

        if (Input.GetKeyDown("left"))
        {   
            FindObjectOfType<audioManager>().Play("swipe");
            currentPoint -=1;
            if (currentPoint == -1){
                currentPoint = 3;
            }

        }

        if (Input.GetKeyDown("right"))
        {
            FindObjectOfType<audioManager>().Play("swipe");

            currentPoint +=1;
            if (currentPoint == 4){
                currentPoint = 0;
            }
        }

        CalculateMovement();
    }

    void CalculateMovement()
    {
        Vector3 firstPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z); 
        Vector3 secondPosition = new Vector3(secondX, secondY, secondZ);    

        transform.position = Vector3.Lerp(firstPosition, secondPosition, 0.03f);

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(rotationX, 0, rotationZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * rotationSpeed);
    }
}