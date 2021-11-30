using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float horizontalSpeed = 2.0F;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");

        //transform.Rotate(-h, h, 0);
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
