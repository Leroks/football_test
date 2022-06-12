using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messi : MonoBehaviour
{
    public bool top;
    public GameObject topObj;

    public float sut1,sut2,hava1,hava2;
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        if(top){
            if(Input.GetMouseButtonDown (0)) {
                topObj.GetComponent<Rigidbody>().velocity = transform.TransformDirection (new Vector3 (0,Random.Range(hava1,hava2),Random.Range(sut1,sut2)));
            }
        }
    }
}
