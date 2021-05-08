using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class Portal : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject MeditationChamber;

    void Start()
    {
        MeditationChamber.SetActive(false);
    }

    void OnTriggerStay(Collider collider)
    {
        MeditationChamber.SetActive(true);
    }
}
