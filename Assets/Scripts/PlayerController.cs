using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{

    public float speed = 0;
    public float maxSpeed = 0;
    public float maxFallSpeed = 0;
    public float drag = 0;


    //public GameObject winTextObject;
    public Transform respawnPoint;

    Vector3 movement;

    private int deaths = 0;
    private Rigidbody rb;
    private float movementX, movementY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //winTextObject.SetActive(false);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }


    void FixedUpdate()
    {
        
        movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(Vector3.ClampMagnitude(movement, maxSpeed) * speed);
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Death"))
        {
            Debug.Log("You Died!!!");
            transform.position = respawnPoint.transform.position;

            freezePlayer(rb);
            deaths++;
        }    

        if (other.gameObject.CompareTag("Respawn"))
        {
            unfreezePlayer(rb);
        }
    }

    void freezePlayer(Rigidbody rb)
    {
        rb.drag = 99999999999;
    }

    void unfreezePlayer(Rigidbody rb)
    {
        rb.drag = drag;
    }


}
