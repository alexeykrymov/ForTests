using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalF : MonoBehaviour
{
    public float vertical;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);
    }
}
