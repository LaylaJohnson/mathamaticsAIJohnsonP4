using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 goal = new Vector3(5,0,4);
    
    // Start is called before the first frame update
    void Start()
    {
        goal = goal * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(goal);
    }
}
