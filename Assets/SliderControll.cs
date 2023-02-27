using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControll : MonoBehaviour
{
    [SerializeField] Slider slider;
   public void Volume()
    {
        AudioListener.volume = slider.value;
    }
}
