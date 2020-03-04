using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPTD
{
    public class Path : MonoBehaviour
    {

        public List<NodeP> nodes = new List<NodeP>();

        public NodeP start
        {
            get{
                return nodes[0];
            }
        }

        public NodeP finish
        {
            get
            {
                return nodes[nodes.Count-1];
            }
        }



        public int countNode
        {
            get
            {
                return nodes.Count;
            }
        }


        // Start is called before the first frame update
        void Start()
        {
            foreach (Transform child in transform) {
                NodeP n = new NodeP();
                n.name = child.name;
                AddNode(n);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnDrawGizmos()
        {
            if (transform.childCount < 2) {
                return;
            }

            for (int i = 0;i < transform.childCount ; i++) {
                Gizmos.DrawLine(transform.GetChild(i - 1).position, transform.GetChild(i).position);
            }
        }

        private void PrintNodes() {
            nodes.ForEach((node) => {
                Debug.Log(node.name);
            });
        }

        public void GenerateNodes() {
            Debug.Log("GenerateNodes");
            GameObject n = new GameObject("Node" + countNode);

            
            if (transform.childCount > 1) {
                n.transform.position = transform.GetChild(transform.childCount - 1).position;
            }

            n.transform.parent = transform;

        }
        public void AddNode(NodeP node) {
            nodes.Add(node);
        }
        public Vector3 GetPosition(NodeP from, NodeP to) {
            return Vector3.zero;
        }
        public float GetDistance(NodeP from, NodeP to)
        {
            return -1;
        }


    }
}