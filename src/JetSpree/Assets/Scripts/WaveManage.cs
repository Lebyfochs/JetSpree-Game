using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Numerics;


//Creates the amplitude of the waves themselves.

public class WaveManage : MonoBehaviour
{
    public static WaveManage instance;

    private float amplitude = 2.0f;
    private float waveLength = 2.0f;
    private float waveSpeed = 1.0f;
    private float offSet = 0.0f;

    private Vector4 waveA;
    private Vector4 waveB;
    private Vector4 waveC;

    //wave vector = x,y DIRS z amplitude w is wavelength

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        if (gameObject.GetComponent<MeshRenderer>().material.HasProperty(Shader.PropertyToID("_WaveA")))
            waveA = gameObject.GetComponent<MeshRenderer>().material.GetVector(Shader.PropertyToID("_WaveA"));
        if (gameObject.GetComponent<MeshRenderer>().material.HasProperty(Shader.PropertyToID("_WaveB")))
            waveB = gameObject.GetComponent<MeshRenderer>().material.GetVector(Shader.PropertyToID("_WaveB"));
        if (gameObject.GetComponent<MeshRenderer>().material.HasProperty(Shader.PropertyToID("_WaveC")))
            waveC = gameObject.GetComponent<MeshRenderer>().material.GetVector(Shader.PropertyToID("_WaveC"));

    }

    private void GerstnerWave()
    {

    }

    private void Update()
    {
        offSet += Time.deltaTime * waveSpeed;
    }


    public Vector3 GerstnerWave(Vector4 wave, Vector2 p, ref Vector3 tangent, ref Vector3 binormal)
    {
        float steepness = waveA.z;
        float wavelength = waveA.w;
        float k = 2 * Mathf.PI / waveA.w;
        float c = Mathf.Sqrt(9.8f / k);
        Vector2 d = new Vector2 (waveA.x, waveA.y);
        d.Normalize();
        float f = k * Vector2.Dot(d, new Vector2 (p.x, p.y)) - c * Time.deltaTime;
        float a = steepness / k;

        tangent += new Vector3(
            -d.x * d.x * (steepness * Mathf.Sin(f)),
            d.x * (steepness * Mathf.Cos(f)),
            -d.x * d.y * (steepness * Mathf.Sin(f))
            );
        binormal += new Vector3(
            -d.x * d.y * (steepness * Mathf.Sin(f)),
            d.y * (steepness * Mathf.Cos(f)),
            -d.y * d.y * (steepness * Mathf.Sin(f))
            );
        return new Vector3(
            d.x * (a * Mathf.Cos(f)),
            a * Mathf.Sin(f),
            d.y * (a * Mathf.Cos(f))
            );
    }

    public float Vert(Vector3 boatPos)
    {
        Vector3 boatPos3 = boatPos;
        Vector3 tangent = new Vector3(1, 0, 0);
        Vector3 binormal = new Vector3(0, 0, 1);
        Vector3 p = boatPos3;
        p += GerstnerWave(waveA, boatPos3, ref tangent, ref binormal);
        p += GerstnerWave(waveB, boatPos3, ref tangent, ref binormal);
        p += GerstnerWave(waveC, boatPos3, ref tangent, ref binormal);
        Vector3 normal = Vector3.Normalize(Vector3.Cross(binormal, tangent));

        return p.y;

    }
}
