using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyBindings : MonoBehaviour
{
    KeyCode interactKey;
    KeyCode flashLightKey;

    public KeyCode InteractKey { get => interactKey;}
    public KeyCode FlashLightKey { get => flashLightKey; }
    private static PlayerKeyBindings instance;
    public static PlayerKeyBindings Instance { get { return instance; } }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        interactKey = KeyCode.E;
        flashLightKey = KeyCode.Mouse0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
