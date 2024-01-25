using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class LoadScene : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (Keyboard.current.eKey.ReadValue() == 1)
            SceneManager.LoadScene(2);
    }
}
