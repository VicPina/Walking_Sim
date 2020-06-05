using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour 
{
    public LayerMask mask;
    public Camera fpv;
    // Update is called once per frame
    void Update()
    {
        Ray ray = fpv.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, 100, mask)) 
        {
            print(hitInfo.collider.gameObject.GetComponent("objectManager").name);
            Debug.DrawLine(ray.origin, hitInfo.point, Color.yellow);
            if(Input.GetMouseButtonDown(0)) { Destroy(hitInfo.transform.gameObject); }
        }
        else { Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.white); }
    }
}
