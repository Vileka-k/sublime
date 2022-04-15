using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMover : MonoBehaviour
{
    public float[] pointVector0 = {0.01f, 7.46f, -13.23f};
    public float[] pointVector1 = {-0.12f, 6.92f, -13.23f};
    public float[] pointVector2 = {0.12f, 7.04f, -13.23f};
    public float[] pointVector3 = {0f, 6.98f, -13.23f};

    public float[] rotationXVals = {0.8f, 0.00f, 0.41f, 0.0f};
    public float[] rotationYVals = {0.0f, 0.00f, 0.41f, 0.0f};
    public float[] rotationZVals = {0.8f, 90.0f, 180.0f, 270.0f};

    private float secondX;
    private float secondY;
    private float secondZ;
    public float rotationX;
    public float rotationY;
    public float rotationZ;

    public float movementSpeed;
    public float rotationSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (girlKeyControl.currentPoint == 0){
            secondX = pointVector0[0];
            secondY = pointVector0[1];
            secondZ = pointVector0[2];

            rotationX = rotationXVals[0];
            rotationY = rotationYVals[0];
            rotationZ = rotationZVals[0];
        }

        if (girlKeyControl.currentPoint == 1){
            secondX = pointVector1[0];
            secondY = pointVector1[1];
            secondZ = pointVector1[2];

            rotationX = rotationXVals[1];
            rotationY = rotationZVals[0];
            rotationZ = rotationZVals[1];
        }

        if (girlKeyControl.currentPoint == 2){
            secondX = pointVector2[0];
            secondY = pointVector2[1];
            secondZ = pointVector2[2];

            rotationX = rotationXVals[2];
            rotationY = rotationYVals[0];
            rotationZ = rotationZVals[2];
        }

        if (girlKeyControl.currentPoint == 3){
            secondX = pointVector3[0];
            secondY = pointVector3[1];
            secondZ = pointVector3[2];

            rotationX = rotationXVals[3];
            rotationY = rotationYVals[0];
            rotationZ = rotationZVals[3];
        }

        CalculateMovement();
    }

    void CalculateMovement()
    {
        Vector3 firstPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z); 
        Vector3 secondPosition = new Vector3(secondX, secondY, secondZ);    

        transform.position = Vector3.Lerp(firstPosition, secondPosition, 0.03f);

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(rotationX, rotationY, rotationZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * rotationSpeed);
    }
}
