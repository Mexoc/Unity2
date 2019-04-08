using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Objects
{
    public class ObjectManager : MonoBehaviour
    {
        [SerializeField]
        private Ammunition[] _ammunitions = new Ammunition[5];
        [SerializeField]
        private Weapon[] _weapons = new Weapon[5];
        
        public Weapon[] GetWeapons
        {
            get { return _weapons; }
        }
        
        public Ammunition[] GetAmmunition
        {
            get { return _ammunitions; }
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }
    }
}

