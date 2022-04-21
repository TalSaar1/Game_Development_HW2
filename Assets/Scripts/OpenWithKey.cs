using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for Text

public class OpenWithKey : MonoBehaviour
{  private Animator animator;
   public GameObject key;
   public Text getKeyText;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
		getKeyText.gameObject.SetActive(true);
		if(key.active){
			getKeyText.text = "You need the key";
		}else{
			getKeyText.text = "you can pass";
			animator.SetBool("lockedDoorOpens", true);
		}
		
		
    }
    private void OnTriggerExit(Collider other)
    {
		getKeyText.gameObject.SetActive(false);
        animator.SetBool("lockedDoorOpens", false);  
    }


}