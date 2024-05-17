using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LampLight : MonoBehaviour
{
    private bool lightOn = false;
    public GameObject pointLight;  

    // toggle light on and off
    public void ChangeState()
    {
        lightOn = !lightOn;
        pointLight.SetActive(lightOn);
    } 
}
