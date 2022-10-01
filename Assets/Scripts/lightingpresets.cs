using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "Lighting presets", menuName = "Scriptables/Lighting presets", order = 1)]
public class lightingpresets : ScriptableObject
{


    public Gradient AmbientColor;                   //these two are now menu items for ease of access
    public Gradient Directionalcolor;
    public Gradient fogcolor;                        //dont touch this shit
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
