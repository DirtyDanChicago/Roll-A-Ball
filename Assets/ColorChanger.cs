using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    MeshRenderer meshRenderer;
   

    // Use this for initialization
    void Start ()
    {
        //This should gather the color component of the player, and sets default to white.
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.white;

    }

// Update is called once per frame
    void Update ()
    {
        //If player hits Q, color turns yellow.
        if ((Input.GetKey("q")))
        {
           meshRenderer.material.color = Color.yellow;
        }

        //If player hits E, color turns green.
        if ((Input.GetKey("e")))
        {
            meshRenderer.material.color = Color.green;
        }
	}
}
