using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    public float velocity;
    void Start()
    {
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(ActivateEventArgs arg) 
    {
        GameObject newBullet = Instantiate(bullet);
        newBullet.transform.position = barrel.transform.position;
        newBullet.GetComponent<Rigidbody>().velocity = barrel.transform.forward* velocity;
        Destroy(newBullet, 5);
    }
}
