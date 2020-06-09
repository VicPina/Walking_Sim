using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour 
{
    public LayerMask mask;
    public Camera fpv;

    public string hitName;
    // Update is called once per frame
    void Update()
    {
        Ray ray = fpv.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, 5, mask)) 
        {
            hitName = hitInfo.collider.gameObject.GetComponent<objectManager>().itemName;
            FindObjectOfType<UIText>().DisplayName(hitName);

            Debug.DrawLine(ray.origin, hitInfo.point, Color.yellow);
            if(Input.GetMouseButtonDown(0)) { hitInfo.transform.gameObject.GetComponent<objectManager>().Interaction(); }
        }
        else 
        {             
            hitName = "";
            FindObjectOfType<UIText>().DisplayName(hitName);
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 5, Color.white);
        }
    }
}
