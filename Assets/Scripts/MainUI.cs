using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] private Transform placeToShow;
    [SerializeField] private GameObject marketPrefab;

    [SerializeField] private GameObject closeSubWindowBtn;
    
    private GameObject _currentWindow;
    
    public void ShowMarket()
    {
        _currentWindow = Instantiate(marketPrefab, placeToShow);
        closeSubWindowBtn.SetActive(true);
    }

    public void CloseCurrentWindow()
    {
        Destroy(_currentWindow);
        closeSubWindowBtn.SetActive(false);
    }

}
