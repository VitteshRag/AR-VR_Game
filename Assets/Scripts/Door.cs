using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator doorAnim1,doorAnim2;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            doorAnim1.SetTrigger("Open");
            doorAnim2.SetTrigger("Open");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            doorAnim1.SetTrigger("Close");
            doorAnim2.SetTrigger("Close");
    }
}
