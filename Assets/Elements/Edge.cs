using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Elements 
{
    public class Edge : MonoBehaviour, IElement
    {
        private LineRenderer edge;
        void Start()
        {
            edge = GetComponent<LineRenderer>();
            edge.SetVertexCount(2);
        }

        public void SetPositions(Transform start, Transform end)
        {
           // edge.enabled = true;
            edge.SetPosition(0, start.transform.position);
            edge.SetPosition(1, end.transform.position);
        }
    }
}
