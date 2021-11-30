using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject player;
    public float strength;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Bounce!");
            other.attachedRigidbody.AddForce(0.0f, strength, 0.0f);
        }
    }
}
