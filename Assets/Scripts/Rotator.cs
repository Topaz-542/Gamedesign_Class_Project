using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    int rotateY;

    void Start()
    {
        rotateY = Random.Range(30, 90);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateY, 0) * Time.deltaTime);
    }
}
