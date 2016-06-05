using UnityEngine;
using Assets;
using System.Collections;

//[ExecuteInEditMode]
public class GraphCreator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] vertices = { 1, 2, 3, 4, 5 };
        int[,] edges = { {1, 2}, { 1, 3 }, { 1, 4 }, { 2, 3 }, { 3, 5 }};
        GameObject go = new GameObject();
        GraphParser graphParser = go.AddComponent<GraphParser>();
        graphParser.Parse(vertices, edges);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
