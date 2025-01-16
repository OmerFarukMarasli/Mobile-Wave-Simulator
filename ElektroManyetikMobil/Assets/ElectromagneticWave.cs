using UnityEngine;

public class ElectromagneticWave : MonoBehaviour
{
    public float frequency = 10.0f; // frekans
    public float amplitude = 1.0f; // genlik
    public float wavelength = 10.0f; // dalga boyu


    private float phase = 0.0f;

    void Update()
    {
        phase += Time.deltaTime * frequency;
        float value = Mathf.Sin(phase) * amplitude;
        transform.position = new Vector2(transform.position.x, value);
        
    }
}