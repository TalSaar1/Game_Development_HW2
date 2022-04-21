using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for Text

public class PickCoin : MonoBehaviour
{
    public Text keyText;
    //public Text info;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        this.gameObject.SetActive(false);
        keyText.text = "Key acquired ";
      
    }
}
