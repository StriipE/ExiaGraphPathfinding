using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Elements
{
    public class Vertex : MonoBehaviour, IElement
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public static Vertex CreateComponent(GameObject gameObject, int id, Vector3 position)
        {
            Vertex newComponent = gameObject.AddComponent<Vertex>();
            newComponent.Id = id;          
            newComponent.transform.position = position;
            return newComponent;
        }

    }
}
