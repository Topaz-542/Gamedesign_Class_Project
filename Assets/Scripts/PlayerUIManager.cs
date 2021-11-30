using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{

    private int count;

    [SerializeField]
    public TextMeshProUGUI countText;
    [SerializeField]
    public GameObject blueGem;
    [SerializeField]
    public GameObject redGem;
    [SerializeField]
    public GameObject greenGem;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        blueGem.SetActive(false);
        redGem.SetActive(false);
        greenGem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetCountText()
    {
        countText.text = "Score: $" + count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            //other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }

        if(other.gameObject.CompareTag("Blue Gem"))
        {
            //other.gameObject.SetActive(false);
            blueGem.SetActive(true);
        }

        if (other.gameObject.CompareTag("Red Gem"))
        {
            //other.gameObject.SetActive(false);
            redGem.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("Green Gem"))
        {
            //other.gameObject.SetActive(false);
            greenGem.SetActive(true);
        }
    }
}
