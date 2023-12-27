using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;
using Models;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ProductDetailsUI : MonoBehaviour
{
    [CanBeNull] private Product _currentProduct;

    [SerializeField] private TextMeshPro _titleField;
    [SerializeField] private TextMeshPro _costField;
    [SerializeField] private TextMeshPro _descriptionField;
    [SerializeField] private Image _productImage;

    public void SetProduct(Product product)
    {
        _currentProduct = product;
        UpdateUIFields();
    }

    private void UpdateUIFields()
    {
        _titleField.text = _currentProduct?.Title;
        _costField.text = _currentProduct?.Cost.ToString(CultureInfo.InvariantCulture);
        _descriptionField.text = _currentProduct?.Description;
    }
}
