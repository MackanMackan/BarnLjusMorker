using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RechargeFlashlight : MonoBehaviour, IInteract
{
    TMP_Text rechargeText;
    GameObject flashlight;
    void Start()
    {
        flashlight = GameObject.Find("Flashlight");
        rechargeText = GameObject.Find("RechargeText").GetComponent<TMP_Text>();
    }

    void RechargeFlashlightBattery()
    {
        flashlight.SetActive(true);
        rechargeText.text = "";
        FlashlightDrain.flashlightPower = FlashlightDrain.maxFlashlightPower;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rechargeText.text = "";
            CancelInvoke(nameof(RechargeFlashlightBattery));
        }
    }

    public void Interact()
    {
        if (!IsInvoking(nameof(RechargeFlashlightBattery)))
        {
            rechargeText.text = "Recharging Flashlight...";
            flashlight.SetActive(false);
            Invoke(nameof(RechargeFlashlightBattery), 3);
        }
    }
}
