using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private RectTransform contentHolder;
    [SerializeField] private Sprite enemyImage;
    [SerializeField] private Color enemyHealthColor;
    [SerializeField] private GameObject healthBarPrefab;

    void OnEnable()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Enemy e = enemy.GetComponent<Enemy>();
            instantiateEnemyHealthBar(healthBarPrefab, e);
        }
    }

    private void instantiateEnemyHealthBar(GameObject healthBarPrefab, Enemy e)
    {
        GameObject enemyHealthBar = Instantiate(healthBarPrefab, contentHolder.transform);
        if (enemyHealthBar != null)
        {
            HPElement enemyHPElement = enemyHealthBar.GetComponent<HPElement>();
            enemyHPElement.SetImage(enemyImage);
            enemyHPElement.SetHealthBar((e.health / 100), enemyHealthColor);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}