using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateThunderMask : MonoBehaviour
{
    public GameObject thunderMask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivateMask()
    {
        thunderMask.SetActive(true);
    }
    public void DeactivateMask()
    {
        thunderMask.SetActive(false);
    }
}
