using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aanpassingen voor de Camera in de Inspector, op de player zelf:
//Field of View = 80 (Past aan hoe ver je kijkt. 60 is de standaard maar 80 is beter)
//Transform Reset
//Zet deze Camera op de "Camera Holder" in de player

//Zet dit script vooral op de Camera Holder, niet de Camera zelf.

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform cameraPosition;
  
    void Update()
    {
        transform.position = cameraPosition.position;

    }
}
