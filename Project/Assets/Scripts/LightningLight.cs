using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UnityStandardAssets.Effects
{
    public class LightningLight : MonoBehaviour
    {
        public float S_Rnd;
        public float E_Rnd;
        private Light m_Light;


        private void Start()
        {
            m_Light = GetComponent<Light>();
        }


        private void Update()
        {
            m_Light.intensity = Random.Range(S_Rnd, E_Rnd);
            
        }
    }
}
