using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;
using Models;
using TMPro;
using UnityEditor.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MarketScript : MonoBehaviour
{
    [SerializeField] private GameObject _productContainer;
    [SerializeField] private GameObject _productPrefab;
    [SerializeField] private MarketManager _marketManager;
    
    public void Start()
    {
        var products = Product.GetProducts();
        foreach (var product in products)
        {
            var instantiatedObj = Instantiate(_productPrefab, _productContainer.transform);
            instantiatedObj.transform.GetChild(0).GetComponent<Image>().sprite = product.Sprite;
            instantiatedObj.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = product.Title;
            instantiatedObj.GetComponent<Button>().onClick.AddListener(delegate { _marketManager.SetProductDetails(product.Id); });
                
        }
    }

}
