using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(AudioSource))]
public class VinylPlayer : MonoBehaviour
{
    private AudioSource audioSource; 

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    } 

    // This method is called when the object is placed in the socket
    public void PlayMusic(SelectEnterEventArgs args)
    { 
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    // This method is called when the object is removed from the socket
    public void StopMusic(SelectExitEventArgs args)
    { 
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
