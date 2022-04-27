using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public List<ObjectMessagePair> objects;

    public float castDistance = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateRaycast()
    {

        // update raycasy
        RaycastHit hitObject;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitObject, castDistance))
        {
            hitObject.transform.gameObject.GetComponent<Switch>()
        }
    }
}
