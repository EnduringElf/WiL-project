using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class WaterBehaviour : MonoBehaviour
{

    Mesh mymesh;
    MeshFilter MeshFilter;

    [SerializeField] Vector2 planeSize = new Vector2(1, 1);
    [SerializeField] int PlaneResolution = 1;

    List<Vector3> Vertices;
    List<int> triangles;
    private void Awake()
    {
        mymesh = new Mesh();
        MeshFilter = GetComponent<MeshFilter>();
        MeshFilter.mesh = mymesh;
        
    }

    private void Update()
    {
        PlaneResolution = Mathf.Clamp(PlaneResolution, 1,300);

        GeneratePlane(planeSize, PlaneResolution);
        LefttoRightSine(Time.timeSinceLevelLoad);
        AssignMesh();
    }

    private void AssignMesh()
    {
        mymesh.Clear();
        mymesh.vertices = Vertices.ToArray();
        mymesh.triangles = triangles.ToArray();
    }

    private void LefttoRightSine(float time)
    {
        for(int i = 0; i < Vertices.Count; i++)
        {
            Vector3 vertex = Vertices[i];
            vertex.y = Mathf.Sin(time + vertex.x);
            Vertices[i] = vertex;
        }
    }

    private void GeneratePlane(Vector2 size, int res)
    {
        Vertices = new List<Vector3>();
        float XperStep = size.x / res;
        float YperStep = size.y / res;
        for(int y = 0; y< res + 1; y++)
        {
            for (int x = 0; x < res + 1; x++)
            {
                Vertices.Add(new Vector3(x * XperStep, 0, y * YperStep));
            }
        }

        triangles = new List<int>();

        for(int row = 0; row <res;row++)
        {
            for (int columns = 0; columns < res; columns++)
            {
                int i = (row * res) + row + columns;

                triangles.Add(i);
                triangles.Add(i + (res) + 1);
                triangles.Add(i + (res) + 2);

                triangles.Add(i);
                triangles.Add(i + (res) + 2);
                triangles.Add(i + 1);

            }
        }

    }
}
