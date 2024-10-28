using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControll : MonoBehaviour
{
    public bool isPushed = false;
    //public GameObject canonSpawner;
    //public GameObject canonBall;

   
    private void OnCollisionEnter(Collision collision)
    {
        if(!isPushed)
        {
            isPushed = true;
            Debug.Log("Button was pushed!!");
            StartCoroutine(ButtonReset());
        }
        
    }

    IEnumerator ButtonReset()
    {
        yield return new WaitForSeconds(5);
        isPushed = false;
    }
}
