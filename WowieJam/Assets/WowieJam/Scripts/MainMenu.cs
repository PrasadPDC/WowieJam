using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MainMenu : MonoBehaviour, ISelectHandler, IPointerEnterHandler, IPointerExitHandler
{

  public GameObject notSelected;

    public void OnPointerEnter(PointerEventData eventData)
    {
      notSelected.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      notSelected.SetActive(true);
    }

    public void OnSelect(BaseEventData eventData)
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
