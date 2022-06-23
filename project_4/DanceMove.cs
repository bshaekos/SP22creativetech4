using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceMove : MonoBehaviour
{
    public ParticleSystem confetti;

  private void OnTriggerEnter (Collider other)
  {
        if (other.gameObject.CompareTag("Player"))
        {

            var em = confetti.emission;

            em.enabled = true;
            confetti.Play();
        }

        Debug.Log("Object Entered the trigger");
  }

    private void OnTriggerExit(Collider other)
    {

        var em = confetti.emission;

        em.enabled = false;
        confetti.Stop();

        Debug.Log("Object Exited the trigger");
    }
}
