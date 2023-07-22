using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelrotation : MonoBehaviour
{
    public GameObject obj;
    private bool isRotating = true; 

    void Update()
    {
        if (isRotating)
        {
         
            obj.transform.Rotate(Vector3.up * Time.deltaTime * 50f);
        }
    }


    public void ToggleRotation()
    {
        isRotating = !isRotating;
    }

    public void Togglezero()
    {
       if (obj != null)
        {
            obj.transform.rotation = Quaternion.Euler(0f,-90,0f);
            //Vector3 currentRotation = obj.transform.rotation.eulerAngles;
            //currentRotation.y = Mathf.Round(currentRotation.y / 90f) * 90f;
            //obj.transform.rotation = Quaternion.Euler(0f, currentRotation.y, 0f); 
        }
    }
}
