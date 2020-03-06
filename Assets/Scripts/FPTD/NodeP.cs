using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPTD { 
public class NodeP
{
        public string name;
        public List<NodeP> exits;

        private Vector3 _position;

        public Vector3 position {   
            get {
                return _position;
            }
        }

        public NodeP(Vector3 position)
        {
            name = "New Node";
            exits = new List<NodeP>();
            _position = position;
        }

        public void AddExit(NodeP node)
        {
            exits.Add(node);
        }

        public void RemoveExit(NodeP node)
        {
            exits.Remove(node);
        }

        public NodeP GetRandomExit()
        {
            return exits[Random.Range(0, exits.Count)];
        }
    }
}