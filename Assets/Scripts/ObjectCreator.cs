using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCube;

    GameObject createdObject;
    // Start is called before the first frame update
    void Start()
    {
        createdObject = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 rayPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        createdObject.SetActive(false);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            createdObject.transform.position = hit.point;
        }
        createdObject.SetActive(true);
        /*Vector3 worldPosition = Camera.main.ScreenToWorldPoint(rayPosition);
        Debug.Log("Posición en pantalla = " + Input.mousePosition + " pos world " + worldPosition);*/
    }

}
