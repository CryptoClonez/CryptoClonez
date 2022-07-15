using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public static event Action SpaceKey;
    public static event Action RKey;
    public static event Action AKey;
    public static event Action DKey;
    public static event Action ZKey;
    public static event Action SKey;
    public static event Action HKey;

    private void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            SpaceKey?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RKey?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AKey?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DKey?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ZKey?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SKey?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            HKey?.Invoke();
        }
    }
}
