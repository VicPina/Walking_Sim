using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class objectManager : MonoBehaviour
{
    public bool isOpen;
    public float openAngle, openDistance;
    public string openDirection;
    private Vector3 backup;
    
    public string itemName;
    public string itemDialogue;

    public UnityEvent DefaultAction;

    public void Awake()
    {
        backup = gameObject.transform.localPosition;
    }

    // Update is called once per frame
    public void Interaction()
    {
        DefaultAction.Invoke();
    }

    public string GetName() { return itemName; }
    public string GetDialogue() { return itemDialogue; }

    public void Door()
    {
        string aux = openDirection;
        if (isOpen) { openDirection = " "; }
        switch (openDirection)
        {
            case "x":
                transform.localRotation = Quaternion.Euler(openAngle, 0f, 0f);
                isOpen = true;
                break;
            case "y":
                transform.localRotation = Quaternion.Euler(0f, openAngle, 0f);
                isOpen = true;
                break;
            case "z":
                transform.localRotation = Quaternion.Euler(0f, 0f, openAngle);
                isOpen = true;
                break;
            default:
                transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                openDirection = aux;
                isOpen = false;
                break;
        }
    }
   
   public void Interact()
    {
        Destroy(gameObject);
    }

    public void Drawer()
    {
        string aux = openDirection;
        Vector3 change = gameObject.transform.localPosition;
        if (isOpen) { openDirection = " "; }
        switch (openDirection)
        {
            case "x":
                change.x = openDistance;
                backup.x = gameObject.transform.localPosition.x;
                isOpen = true;
                break;
            case "z":
                change.z = openDistance;
                backup.z = gameObject.transform.localPosition.z;
                isOpen = true;
                break;
            case "y":
                change.y = openDistance;
                backup.y = gameObject.transform.localPosition.y;
                isOpen = true;
                break;
            default:
                change = backup;
                openDirection = aux;
                isOpen = false;
                break;
        }
        gameObject.transform.localPosition = change;

    }

    private void Blunderbuss()
    {

    }
    
    //Para prender y encender luces

    var entro, boolean;
    var Luz, GameObject;
    public void Lights()
    {
        if (entro == false)
        {
            Luz.active = false;
        }

        if (entro == true)
        {
            Luz.active = true;
        }
    }

    function OnTriggerEnter() 
    {
        entro == true;
    }

    function OnTriggerEnter()
    {
        entro == false;
    }

    //go to sleep
    public void GoTosleep()
    {

    }
}
