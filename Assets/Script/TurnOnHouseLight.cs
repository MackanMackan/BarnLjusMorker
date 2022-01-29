using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class TurnOnHouseLight : MonoBehaviour, IInteract
{
    Light2D globalLight;
    [SerializeField]
    GameObject spriteMask;
    
    void Start()
    {
        globalLight = GameObject.Find("GlobalLight").GetComponent<Light2D>();
    }


    void turnOnLight()
    {
        spriteMask.SetActive(true);
        globalLight.intensity = 1f;
    }

    public void Interact()
    {
        turnOnLight();
    }
}
