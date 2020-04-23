using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedMesh : MonoBehaviour
{
    public Vector3[] vertex;
    public Vector2[] uvmap;
    public int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        //int[] a = [1, 2, 7, 4, 10];
        
        //Vertex
        vertex = new Vector3[] { new Vector3(-1, 0, 1),
                                 new Vector3(1, 0, 1),
                                 new Vector3(1, 0, -1),
                                 new Vector3(-1, 0, -1)};
        //uv map
        uvmap = new Vector2[] { new Vector2(0, 256),
                                new Vector2(256, 256),
                                new Vector2(256, 0),
                                new Vector2(0, 0)};
        //triangles
        triangles = new int[] { 0, 1, 2,
                                0, 2, 3};

        Mesh mesh = new Mesh();
        mesh.vertices = vertex;
        mesh.triangles = triangles;
        mesh.uv = uvmap;
        MeshFilter filter = gameObject.AddComponent<MeshFilter>();
        filter.mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
