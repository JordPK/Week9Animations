using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DoorOpen"))
        {
            anim.SetBool("isDoorOpen", true);
        }
        if (other.CompareTag("DoorOpen2"))
        {
            anim.SetBool("isDoorOpenReverse", true);
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DoorOpen"))
        {
            anim.SetBool("isDoorOpen", false);
        }

        if (other.CompareTag("DoorOpen2"))
        {
            anim.SetBool("isDoorOpenReverse", false);
        }
    }
}
