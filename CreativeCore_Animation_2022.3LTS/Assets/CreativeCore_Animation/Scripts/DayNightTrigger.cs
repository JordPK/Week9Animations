using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightTrigger : MonoBehaviour
{

    [SerializeField] Animator anim;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sunset"))
        {
            anim.SetBool("isSunset", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sunset"))
        {
            anim.SetBool("isSunset", false);
        }
    }
}
