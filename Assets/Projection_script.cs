using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projection_script : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;

    private void OnTriggerEnter(Collider other) {
        particleSystem.Play();
    }

    private void OnTriggerExit(Collider other) {
        particleSystem.Stop();
    }
}
