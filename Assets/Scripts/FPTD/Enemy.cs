﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPTD
{
    public class Enemy : MonoBehaviour
    {
        public int life = 10;
        public float speed = 1f;
        public int minDmg = 1;
        public int maxDmg = 3;
        public NodeP origin = null;
        public NodeP target = null;
        // Start is called before the first frame update
        void Start()
        {
            origin = Path.startNode;
            transform.position = origin.position;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Drop() { }

        public void Death() { }
        public void Damage() { }
       // public void 

    }
}