using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public bool state;
    
    public void onbuttonpress()
    {
        state = !state;
        Debug.Log("press");

        if(state)
        {
            object1.SetActive(false);
            object2.SetActive(true);

        }
        else
        {
            object1.SetActive(true);
            object2.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
