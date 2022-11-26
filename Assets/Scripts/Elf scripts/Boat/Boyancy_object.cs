using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Boyancy_object : MonoBehaviour
{
    public float Underwaterdrag = 3;
    public float UnderwaterAnulardrag = 1;

    public float Airdrag = 0;
    public float Airanulardrag = 0.05f;

    public float floating_power;

    Rigidbody m_Rigidbody;

    bool underwater;

    public float waterHieght = 0f;



    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float diff = transform.position.y - waterHieght;

        if (diff < waterHieght)
        {
            m_Rigidbody.AddForceAtPosition(Vector3.up * floating_power * Mathf.Abs(diff), transform.position, ForceMode.Force);
            if (!underwater)
            {
                underwater = true;
                switchState(true);
            }
        }
        else if (underwater)
        {
            underwater = false;
            switchState(false);
        }
    }

    void switchState(bool Isunderwater)
    {
        if (Isunderwater)
        {
            m_Rigidbody.drag = Underwaterdrag;
            m_Rigidbody.angularDrag = UnderwaterAnulardrag;


        }
        else
        {
            m_Rigidbody.drag = Airdrag;
            m_Rigidbody.angularDrag = Airanulardrag;
        }
    }
}
