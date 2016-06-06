using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Elements 
{
    public class Edge : MonoBehaviour, IElement
    {
        private Vector3 startRender, endRender;
        private LineRenderer edge;
        void Update()
        {
        
        }

        public void SetPositions(Transform start, Transform end)
        {
            startRender = start.transform.position;
            endRender = end.transform.position;
            edge = GetComponent<LineRenderer>();
            edge.SetVertexCount(2);
            edge.enabled = true;
            edge.SetPosition(0, startRender);
            edge.SetPosition(1, endRender);
            edge.SetWidth(0.1f, 0.1f);
        }
    }
}
