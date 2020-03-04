using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPTD
{
    public class Enemy : MonoBehaviour
    {

        public string name;
        public List<NodeP> exits;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void AddExit(NodeP node) { }
        public void RemoveExit(NodeP node) { }
        public NodeP GetRandomExit() {
            return exits[Random.Range(0,exits.Count)];
        }

    }
}