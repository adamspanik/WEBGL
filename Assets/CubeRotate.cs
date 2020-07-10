using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{

    public Vector3 RotateAmount;  // degrees per second to rotate in each axis. Set in inspector.
    private float speedManual = -10.0F;
    private float speedAuto = 100;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("test");
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * speedManual);
        }
        else {
            transform.Rotate(RotateAmount * Time.deltaTime * speedAuto);
        }
    }
}
