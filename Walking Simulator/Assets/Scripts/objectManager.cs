using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class objectManager : MonoBehaviour
{
    public bool isDoor, isTask, isDrawer, isBlunderbuss;
    public float openAngle, openDistance;
    public string openDirection;
    private int run;
    
    public string itemName;
    public string itemDialogue;

    public UnityEvent DefaultAction;
    // Start is called before the first frame update
    void Awake()
    {
        if (isDoor) { run = 0; }
        if (isTask) { run = 1; }
        if (isDrawer) { run = 2; }
        if (isBlunderbuss) { run = 3; }        
    }


    // Update is called once per frame
    public void Interaction()
    {
        DefaultAction.Invoke();
        switch (run)
        {
            case 0:
                Door();
                break;
            case 1:
                Interact();
                break;
            case 2:
                Drawer();
                break;
            case 3:
                Blunderbuss();
                break;

        }
    }

    public string GetName() { return itemName; }
    public string GetDialogue() { return itemDialogue; }

    private void Door()
    {
        switch (openDirection)
        {
            case "x":
                transform.localRotation = Quaternion.Euler(openAngle, 0f, 0f);
                break;
            case "y":
                transform.localRotation = Quaternion.Euler(0f, openAngle, 0f);
                break;
            case "z":
                transform.localRotation = Quaternion.Euler(0f, 0f, openAngle);
                break;
            default:
                transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                break;
        }
    }
   
   private void Interact()
    {
        Destroy(gameObject);
    }

    private void Drawer()
    {
        Vector3 change = transform.localPosition;
        switch (openDirection)
        {
            case "x":
                change.x = openDistance;
                break;
            case "z":
                change.z = openDistance;
                break;
            case "y":
                change.y = openDistance;
                break;
        }
        transform.localPosition = change;

    }

    private void Blunderbuss()
    {

    }
}
