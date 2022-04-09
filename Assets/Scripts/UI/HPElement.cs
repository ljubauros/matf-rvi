using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPElement : MonoBehaviour
{

    [SerializeField] private Image img;
    [SerializeField] private Image healthBar;

    public void SetImage(Sprite image)
    {
        img.sprite = image;
    }

    public void SetHealthBar(float amount, Color barColor)
    {

        healthBar.fillAmount = amount;
        healthBar.color = barColor;
    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }
}
