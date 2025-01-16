using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider frequencyslider;
    public Slider amplitude;
    public Slider wavelength;

    public Animator CanvasAnim;

    ElectromagneticWave electromagnetic;
    public AudioSource ses;

    void Start()
    {
        electromagnetic = GetComponent<ElectromagneticWave>();
    }

    // Update is called once per frame
    void Update()
    {
        electromagnetic.frequency =frequencyslider.value;
        electromagnetic.amplitude = amplitude.value;
        electromagnetic.wavelength = wavelength.value;
    }

    public void ZamanBaslat()
    {
        Time.timeScale = 1f;
        ses.Play();
    }

    public void ZamanDurdur()
    {
        Time.timeScale = 0f;
        ses.Play();
    }
    public void ZamanYavaslat()
    {
        Time.timeScale = 0.75f;
    }

    public void TusaBas()
    {
        CanvasAnim.SetTrigger("Basma");
        ses.Play();
    }
}
