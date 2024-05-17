using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallBounceSound : MonoBehaviour
{
    [Tooltip("The sound that is played when the ball bounces")]
    public AudioClip bounceSound = null;

    [Tooltip("The volume of the sound")]
    public float volume = 1.0f;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Play the bounce sound
        if (bounceSound != null)
        {
            audioSource.PlayOneShot(bounceSound, volume);
        }
    }

    private void OnValidate()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        audioSource.playOnAwake = false;
    }
}
