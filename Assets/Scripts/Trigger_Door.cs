using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Door : MonoBehaviour
{

    public GameObject door;
    [SerializeField]
    AudioSource source;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Crate"))
        {
            door.SetActive(false);
            source.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Crate"))
        {
            door.SetActive(true);
            source.Play();
        }
    }
}
