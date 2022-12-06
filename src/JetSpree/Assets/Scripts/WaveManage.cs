using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Creates the amplitude of the waves themselves.

public class WaveManage : MonoBehaviour
{
    public static WaveManage instance;

    [SerializeField] private float amplitude = 3.0f;
    [SerializeField] private float waveLength = 5.0f;
    [SerializeField] private float waveSpeed = 1.0f;
    [SerializeField] private float offSet = 0.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        offSet += Time.deltaTime * waveSpeed;
    }


    public float getWaveHeight(float _x)
    {
        return amplitude * Mathf.Sin(_x / waveLength + offSet);
    }
}
