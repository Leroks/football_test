using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "Top")
        {
            Debug.Log("Topa dokundu.");
            transform.root.gameObject.GetComponent<Messi>().top = true;
        }
    }
    void OnTriggerStay(Collider nesne)
    {
        if (nesne.gameObject.tag == "Top")
        {
            Debug.Log("Toptayiz");
            transform.root.gameObject.GetComponent<Messi>().top = true;
        }
    }
    void OnTriggerExit(Collider nesne)
    {
        if (nesne.gameObject.tag == "Top")
        {
            Debug.Log("Toptan ayrildi.");
            transform.root.gameObject.GetComponent<Messi>().top = false;
        }
    }
}
