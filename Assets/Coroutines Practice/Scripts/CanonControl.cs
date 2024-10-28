using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonControl : MonoBehaviour
{
    public Rigidbody canonRb;
    public float canonSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        canonRb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        canonRb.AddForce(Vector3.forward * canonSpeed, ForceMode.Impulse);
    }
}
