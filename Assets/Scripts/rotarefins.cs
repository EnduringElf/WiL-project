using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class rotarefins : MonoBehaviour
{
    public GameObject prop;
    public float speed;
    public Transform this_transform;

    // Start is called before the first frame update
    void Start()
    {
        this_transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        prop.transform.RotateAround(this_transform.position, Vector3.forward, speed);
    }
}
