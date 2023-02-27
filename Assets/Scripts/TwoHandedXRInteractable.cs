using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandedXRInteractable : XRGrabInteractable
{
    [SerializeField] private Transform LeftHand;
    [SerializeField] private Transform RightHand;

    [SerializeField] private Transform LeftAttachPoint;
    [SerializeField] private Transform RightAttachPoint;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform == RightHand)
        {
            attachTransform = RightAttachPoint;
            Debug.Log("Right");
        }
        else if (args.interactorObject.transform == LeftHand)
        {
            attachTransform = LeftAttachPoint;
            Debug.Log("Left");
        }

        base.OnSelectEntered(args);
    }
}
