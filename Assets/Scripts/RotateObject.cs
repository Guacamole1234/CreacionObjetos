using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = new Vector3();
        float movY = Input.GetAxis("Vertical");
        movY += rotateSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0f, 10f, 0f);
        }


    }
}
