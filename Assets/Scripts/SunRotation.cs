using UnityEngine;

public class SunRotation : MonoBehaviour {

    [Range(0f, 1f)]
    [SerializeField] private float dayLength = 0.5f;
    [Range(0f, 2f)]
    [SerializeField] private float rotationSpeed = 1;

    void Update()
    {
        rotationSpeed = Time.deltaTime / dayLength;
        transform.Rotate(0, rotationSpeed, 0);
    }
}
