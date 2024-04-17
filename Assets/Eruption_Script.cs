using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Eruption_Script : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;

    private void OnTriggerEnter(Collider other) {
        particleSystem.Play();
    }

    private void OnTriggerExit(Collider other) {
        particleSystem.Stop();
    }
}
