using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField]
    float speedScale = 3f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale += Vector3.one * Input.mouseScrollDelta.y * speedScale * Time.deltaTime;
        transform.localScale = newScale;
    }
}
