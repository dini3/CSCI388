using UnityEngine;

public class AnimateRecticle : MonoBehaviour
{
    // Define the scale limits and speed
    public Vector3 minScale = new Vector3(0.5f, 0.5f, 1f);
    public Vector3 maxScale = new Vector3(2f, 2f, 1f);
    public float speed = 2f;

    private bool scalingUp = true;

    void Update()
    {
        // Determine the target scale based on the current direction
        Vector3 targetScale = scalingUp ? maxScale : minScale;

        // Smoothly scale towards the target scale
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * speed);

        // Check if the object has reached the target scale
        if (scalingUp && Vector3.Distance(transform.localScale, maxScale) < 0.01f)
        {
            scalingUp = false;
        }
        else if (!scalingUp && Vector3.Distance(transform.localScale, minScale) < 0.01f)
        {
            scalingUp = true;
        }
    }
}
