using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectManager : MonoBehaviour
{
    public bool isDoor;
    public bool isTask;
    public bool isDrawer;
    public bool isTrabuquette;

    public string itemName;
    public string itemDialogue;

    public string GetName() { return itemName; }
    public string GetDialogue() { return itemDialogue; }

    // Start is called before the first frame update
    void Start()
    {
        int run;
        switch (run)
        {
              Case 1:
              Transform.eulerrotation.y = 90;
              Break;
              Case 2:
              Break;
              Case 3:
              Transform.forward + = 2;
              Break;
              Case 4:
              Trabouquette();
              Break;
         }
    }


    // Update is called once per frame
    void Update()
    {
          if (isDoor) { run = 0; }
          if (isTask) { run = 1; }
          if (isDrawer) { run = 2; }
          if (isTrabuquette) { run = 3; }
    }

   
   
   

}
