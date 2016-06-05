using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Elements; 

namespace Assets
{
    public class GraphParser : MonoBehaviour
    {
        private List<GameObject> graphVertices;
        public List<GameObject> GraphVertices
        {
            get
            {
                return graphVertices;
            }

            set
            {
                graphVertices = value;
            }
        }

        public void Parse(int[] vertices, int[,] edges)
        {
            GraphVertices = new List<GameObject>(); // Creating the list of objects making the graph

            for (int i = 0; i < vertices.Length; i++) // Creating the GO's for the vertices
            {
                GameObject vertex = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Vertex.CreateComponent(vertex, i, new Vector3(i, i, 0));
                GraphVertices.Add(vertex);
            }

            for (int i = 0; i < edges.Length; i++) // Creating the GO's for the edges 
            {
                GameObject go = new GameObject();
                go.AddComponent<LineRenderer>();
                Edge edge = go.AddComponent<Edge>();
                edge.SetPositions(GraphVertices[edges[i, 0]].transform, GraphVertices[edges[i, 1]].transform);
            }
        }
    }
}
