using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightActivation : MonoBehaviour
{
    GameObject flashlight;
    
    void Start()
    {
        flashlight = GameObject.Find("Flashlight");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PlayerKeyBindings.Instance.FlashLightKey) && FlashlightDrain.flashlightPower > 0)
        {
            ActivateFlashlight();
        }
        else if (FlashlightDrain.flashlightPower <= 0)
        {
            flashlight.SetActive(false);
        }
    }
    void ActivateFlashlight()
    {
        flashlight.SetActive(!flashlight.activeSelf);
    }
}
