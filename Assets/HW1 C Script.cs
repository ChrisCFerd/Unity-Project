using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW1CScript : MonoBehaviour
{
    [SerializeField] float xValue = 0;

    [SerializeField] float yValue = 0;

    [SerializeField] float zValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am a component added to the prefab");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue,yValue,zValue);
        
         Debug.Log("I update with every frame of the prefab");
    }

}
