using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class objectManager : MonoBehaviour
{
    public bool isActive, isCollectible;
    public float openAngle, openDistance;
    public string openDirection, itemName, itemDialogue;

    private Vector3 backup;
    
    public Light lightSource;
    [SerializeField]
    private GameObject uiSummary, UI, player;

    public UnityEvent DefaultAction;

    public void Awake()
    {
        backup = gameObject.transform.localPosition;
        if (isCollectible)
        {
            uiSummary.GetComponent<SummaryManager>().objectsToCollect.Add(itemName);
        }
    }

    public void Interaction()
    {
        DefaultAction.Invoke();
    }

    public void Door()
    {
        string aux = openDirection;
        if (isActive) { openDirection = " "; }
        switch (openDirection)
        {
            case "x":
                transform.localRotation = Quaternion.Euler(openAngle, 0f, 0f);
                isActive = true;
                break;
            case "y":
                transform.localRotation = Quaternion.Euler(0f, openAngle, 0f);
                isActive = true;
                break;
            case "z":
                transform.localRotation = Quaternion.Euler(0f, 0f, openAngle);
                isActive = true;
                break;
            default:
                transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                openDirection = aux;
                isActive = false;
                break;
        }
    }
   
    public void Interact()
    {
        uiSummary.GetComponent<SummaryManager>().objectsCollected.Add(itemName);
        Destroy(gameObject);
    }

    public void Drawer()
    {
        string aux = openDirection;
        Vector3 change = gameObject.transform.localPosition;
        if (isActive) { openDirection = " "; }
        switch (openDirection)
        {
            case "x":
                change.x = openDistance;
                backup.x = gameObject.transform.localPosition.x;
                isActive = true;
                break;
            case "z":
                change.z = openDistance;
                backup.z = gameObject.transform.localPosition.z;
                isActive = true;
                break;
            case "y":
                change.y = openDistance;
                backup.y = gameObject.transform.localPosition.y;
                isActive = true;
                break;
            default:
                change = backup;
                openDirection = aux;
                isActive = false;
                break;
        }
        gameObject.transform.localPosition = change;

    }

    private void Blunderbuss()
    {

    }
    
    //Para prender y encender luces
    public void SwitchLight()
    {
        if (isActive) { lightSource.enabled = false; isActive = false; }
        else if (!isActive) { lightSource.enabled = true; isActive = true; }
    }

    //go to sleep
    public void GoTosleep()
    {
        UI.SetActive(true);
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponentInChildren<MouseLook>().enabled = false;
        player.GetComponentInChildren<Raycast>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
}
