using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(AudioSource))]
public class VinylPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isInSocket = false;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Rotate the object continuously about the y-axis if it is in the socket
        if (isInSocket)
        {
            transform.Rotate(Vector3.up, 45 * Time.deltaTime);
        }
    }

    // This method is called when the object is placed in the socket
    public void PlayMusic(SelectEnterEventArgs args)
    {
        isInSocket = true;
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    // This method is called when the object is removed from the socket
    public void StopMusic(SelectExitEventArgs args)
    {
        isInSocket = false;
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
