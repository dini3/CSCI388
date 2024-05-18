using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VinylHandler : MonoBehaviour
{
    private XRSocketInteractor socketInteractor;
    public GameObject playerHandlle;

    void Start()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
        socketInteractor.selectEntered.AddListener(OnSelectEnter);
        socketInteractor.selectExited.AddListener(OnSelectExit);
    }

    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        var interactable = args.interactableObject;
        var socketInteraction = interactable.transform.GetComponent<VinylPlayer>();
        if (socketInteraction != null)
        {
            socketInteraction.PlayMusic(args);
            playerHandlle.transform.Rotate(Vector3.up, 60);
        }
    }

    public void OnSelectExit(SelectExitEventArgs args)
    {
        var interactable = args.interactableObject;
        var socketInteraction = interactable.transform.GetComponent<VinylPlayer>();
        if (socketInteraction != null)
        {
            socketInteraction.StopMusic(args);
            playerHandlle.transform.Rotate(Vector3.up, -60);
        }
    }
}
