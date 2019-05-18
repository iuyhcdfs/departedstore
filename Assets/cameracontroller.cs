using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newAngle = gameObject.transform.rotation.eulerAngles;
        newAngle.y += Input.GetAxis("Horizontal") * 3;
        newAngle.x += Input.GetAxis("Vertical") * -2;
        transform.rotation = Quaternion.Euler(newAngle);
    }
}
