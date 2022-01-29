using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightDrain : MonoBehaviour
{
    public static float flashlightPower = 100;
    public static float maxFlashlightPower = 100;
    float drainPower = 10;
    GameObject drainStatusImg;
    GameObject flashlight;
    void Start()
    {
        drainStatusImg = GameObject.Find("FlashlightPowerStatus");
        flashlight = GameObject.Find("Flashlight");
    }

    // Update is called once per frame
    void Update()
    {
        if(flashlight.activeSelf)
            DrainFlashlighPower();
    }
    void DrainFlashlighPower()
    {
        flashlightPower -= drainPower * Time.deltaTime;
        flashlightPower = Mathf.Clamp(flashlightPower, 0, 100);
        drainStatusImg.transform.localScale = new Vector3(flashlightPower / 100, 1, 1);
    }
}
