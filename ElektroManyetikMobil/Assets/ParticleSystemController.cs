using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public ElectromagneticWave electromagneticWave;
    

    void Update()
    {
        particleSystem.transform.position = electromagneticWave.transform.position;
        particleSystem.startColor = new Color(1, 1, 1, electromagneticWave.amplitude);
        
    }
}