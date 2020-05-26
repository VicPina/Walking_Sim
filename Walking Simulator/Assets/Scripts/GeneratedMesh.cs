using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class GeneratedMesh : MonoBehaviour
{
    public float speed = 0.1f;
    public Vector3[] vertex;
    public Vector2[] uvmap;
    public int[] triangles;
    private MeshFilter filter;

    private float deltaUV = 0f;
    private void Start()
    {
        CreateMesh();
    }
    private void Update()
    {
        CreateMesh();
    }
    private void CreateMesh()
    {
        // vertices
        vertex = new Vector3[]{ /* vertices cara 1 */
                                new Vector3(-1, 1, 1),      // vertice 0 
                                new Vector3( 1, 1, 1),      // vertice 1 
                                new Vector3( 1, 1, -1),     // vertice 2 
                                new Vector3( -1, 1, -1),    // vertice 3 
                                /* vertices cara 2 */
                                new Vector3(-1, 1, -1),     // vertice 4
                                new Vector3( 1, 1, -1),     // vertice 5
                                new Vector3( 1, -1, -1),    // vertice 6
                                new Vector3( -1, -1, -1),   // vertice 7
                                /* vertices cara 3 */
                                new Vector3(1, 1, -1),      // vertice 8
                                new Vector3( 1, 1, 1),      // vertice 9
                                new Vector3( 1, -1, 1),     // vertice 10
                                new Vector3(1, -1, -1),    // vertice 11
                                /* vertices cara 4 */
                                new Vector3(-1, 1, 1),     // vertice 12
                                new Vector3( -1, 1, -1),     // vertice 13
                                new Vector3( -1, -1, -1),    // vertice 14
                                new Vector3( -1, -1, 1),   // vertice 15
                                 /* vertices cara 5 */
                                new Vector3(1, 1, 1),     // vertice 16
                                new Vector3( -1, 1, 1),     // vertice 17
                                new Vector3( -1, -1, 1),    // vertice 18
                                new Vector3( 1, -1, 1),   // vertice 19
                                /* vertices cara 6 */
                                new Vector3(-1, -1, 1),     // vertice 20
                                new Vector3( 1, -1, 1),     // vertice 21
                                new Vector3( 1, -1, -1),    // vertice 22
                                new Vector3( -1, -1, -1)};  // vertice 23
                                   

        // poligonos
        triangles = new int[] { 0,1,2,      // Cara 1
                                2,3,0,
                                4,5,6,      // Cara 2
                                6,7,4,
                                8,9,10,     // Cara 3
                                10,11,8,
                                12,13,14,   // Cara 4
                                14,15,12, 
                                16,17,18,   // Cara 5
                                18,19,16,
                                20,22,21,   // Cara 6
                                20,23,22
                                };

        // uv map
        float x1 = deltaUV * speed;
        float x2 = 0.125f + deltaUV * speed;

        uvmap = new Vector2[] { /* vertices cara 1 */
                                new Vector2(x1, 1f),
                                new Vector2(x2, 1f),
                                new Vector2(x2, 0.875f),
                                new Vector2(x1, 0.875f),
                                /* vertices cara 2 */
                                new Vector2(x1, 0.875f),
                                new Vector2(x2, 0.875f),
                                new Vector2(x2, 0.75f),
                                new Vector2(x1, 0.75f),
                                /* vertices cara 3 */
                                new Vector2(x1, 0.75f),
                                new Vector2(x2, 0.75f),
                                new Vector2(x2, 0.625f),
                                new Vector2(x1, 0.625f),
                                /* vertices cara 4 */
                                new Vector2(x1, 0.625f),
                                new Vector2(x2, 0.625f),
                                new Vector2(x2, 0.5f),
                                new Vector2(x1, 0.5f),
                                /* vertices cara 5 */
                                new Vector2(x1, 0.5f),
                                new Vector2(x2, 0.5f),
                                new Vector2(x2, 0.375f),
                                new Vector2(x1, 0.375f),
                                /* vertices cara 6 */
                                new Vector2(x1, 0.375f),
                                new Vector2(x2, 0.375f),
                                new Vector2(x2, 0.25f),
                                new Vector2(x1, 0.25f),
                                };

        deltaUV += Time.deltaTime;
        Mesh mesh = new Mesh();
        mesh.vertices = vertex;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        mesh.uv = uvmap;
        filter = gameObject.GetComponent<MeshFilter>();
        filter.mesh = mesh;
    }
}
