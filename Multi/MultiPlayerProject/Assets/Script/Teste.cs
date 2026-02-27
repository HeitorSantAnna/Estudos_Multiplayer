using UnityEngine;
using UnityEngine.InputSystem;

public class Teste : MonoBehaviour
{
    [SerializeField] GameObject cam, cam1;

    [SerializeField] bool ver = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (!ver)
        {
            cam.SetActive(true);
            cam1.SetActive(false);
        }
        else if (ver)
        {
            cam.SetActive(false);
            cam1.SetActive(true);
        }
    }

    public void Verifa(InputAction.CallbackContext value)
    {
        bool fa = value.ReadValueAsButton();

        if(!value.performed)
        {
            return;
        }

        if (fa && !ver)
        {
            ver = true;
        }
        else if (fa && ver)
        {
            ver = false;
        }
    }
}
