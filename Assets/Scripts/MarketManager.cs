using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Models;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MarketManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI productTitle;
    [SerializeField] private TextMeshProUGUI productType;
    [SerializeField] private TextMeshProUGUI productCost;
    [SerializeField] private Image productImage;
    [SerializeField] private TextMeshProUGUI productDescription;
    [SerializeField] private Transform buyButton;
    [CanBeNull] private Product _currentProduct;
    
    public void SetProductDetails(int productId)
    {
        _currentProduct = Product.GetProducts().FirstOrDefault(x => x.Id == productId);
        if (_currentProduct == null)
            return;
        productTitle.text = _currentProduct.Title;
        productCost.text = "Цена: " + _currentProduct.Cost + "$";
        productDescription.text = "Описание: " + _currentProduct.Description;
        productImage.sprite = _currentProduct.Sprite;
        if (productImage.color.a < 255)
            productImage.color = Color.white;
        productType.text = "Тип: предмет";
        if (!buyButton.gameObject.activeSelf)
            buyButton.gameObject.SetActive(true);
    }

    public void BuySelectedProduct()
    {
        Debug.Log($"Вы купили {_currentProduct.Title}");
    }

}
