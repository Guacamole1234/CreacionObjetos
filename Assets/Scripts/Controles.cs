using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    /*[SerializeField]
    GameObject azulito;*/
    //Rigidbody rb;
    [SerializeField]
    bool invertedAxes;
    [SerializeField]
    float movementspeed = 1.5f;
    void Start()
    {
        if (invertedAxes == true) 
        {
            movementspeed = movementspeed * -1f;
        }
        //rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            
        }*/
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(movX, 0f, movZ) * movementspeed * Time.deltaTime;
        //rb.AddForce(movement * velocidad * Time.deltaTime, ForceMode.Impulse);
        transform.Translate(mov);
    }
}
