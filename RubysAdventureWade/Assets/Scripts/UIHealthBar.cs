using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Image mask;
    float originalSize;

    void Start()
    {
        originalSize = mask.rectTransform.rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }
}
