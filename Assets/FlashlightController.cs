using UnityEngine;

/// <summary>
/// Play a simple sound using PlayOneShot with volume and pitch, and toggle a light on and off.
/// </summary>
// [RequireComponent(typeof(Light))]
public class Flashlight : MonoBehaviour
{
    public Light flashlightLight = null;

    private float defaultPitch = 1.0f;
    private bool isLightOn = false;

    private void Awake()
    {

        // Ensure the light is off at the start
        if (flashlightLight != null)
        {
            flashlightLight.enabled = false;
        }
    }

    public void Play()
    {
        // Toggle the light
        if (flashlightLight != null)
        {
            isLightOn = !isLightOn;
            flashlightLight.enabled = isLightOn;
        }
    }

    private void OnValidate()
    {
        Light lightsource = GetComponent<Light>();
    }
}
