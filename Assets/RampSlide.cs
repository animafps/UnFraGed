using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampSlide : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.friction = 0;
    }
}
