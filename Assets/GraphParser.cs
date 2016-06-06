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

        public void Parse(int[] verticies, int[,] edges)
        {
            GraphVertices = new List<GameObject>(); // Creating the list of objects making the graph

            for (int i = 0; i < verticies.Length; i++) // Creating the GO's for the vertices
            {
                GameObject vertex = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Vertex.CreateComponent(vertex, i, new Vector3(UnityEngine.Random.Range(-5.0f, 5.0f), UnityEngine.Random.Range(-5.0f, 5.0f), 0));
                GraphVertices.Add(vertex);
            }

            for (int i = 0; i < edges.Length / 2; i++) // Creating the GO's for the edges 
            {
                GameObject go = new GameObject();
                go.AddComponent<LineRenderer>();
                Edge edge = go.AddComponent<Edge>();
                edge.SetPositions(GraphVertices[edges[i, 0] - 1].transform, GraphVertices[edges[i, 1] - 1].transform);
            }
        }

        public void Update()
        {
            //for (int i = 0; i < edges.Length / 2; i++) // Creating the GO's for the edges 
            //{
            //    edge.SetPositions(GraphVertices[edges[i, 0] - 1].transform, GraphVertices[edges[i, 1] - 1].transform);
            //}
        }


    }
}
