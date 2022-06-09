using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int getal;
    // Start is called before the first frame update
    void Start()
    {
        string name = gameObject.name;//
        Debug.Log(name);
        Debug.Log(gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(getal);
        Debug.LogError("Gael Griffith");
    }
}
