using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ModalController : MonoBehaviour
{
    public ModalOpenType openType;
    
    public Transform modal;
    public float duration;

    public Animator animator;
    
    public bool hasBackground;
    public Image backgroundImage;
    
    public bool isOpen;

    public UnityAction OnOpenModal;
    public UnityAction OnCloseModal;

    private float localScale = 1f;

    public void OpenModal()
    {
        isOpen = true;
        switch (openType)
        {
            case ModalOpenType.onlyOpen:
                OnlyOpen();
                break;
            case ModalOpenType.animator:
                AnimatorOpen();
                break;
            case ModalOpenType.doTween:
                TweenOpen(duration);
                break;

        }
        OnOpenModal?.Invoke();
    }

    public void CloseModal()
    {
        isOpen = true;
        switch (openType)
        {
            case ModalOpenType.onlyOpen:
                OnlyClose();
                break;
            case ModalOpenType.animator:
                AnimatorClose();
                break;
            case ModalOpenType.doTween:
                TweenClose(duration);
                break;

        }
        OnOpenModal?.Invoke();
    }

    #region Open methods

    private void OnlyOpen()
    {
        gameObject.SetActive(true);
    }

    private void AnimatorOpen()
    {
        animator.SetBool("isOpen", true);
    }
    private void TweenOpen(float duration)
    {
        modal.DOScale(Vector3.one * localScale, duration);
    }
    #endregion

    #region Close methods
    private void OnlyClose()
    {
        gameObject.SetActive(false);
    }

    private void AnimatorClose()
    {
        animator.SetBool("isOpen", false);
    }
    private void TweenClose(float duration)
    {
        modal.DOScale(Vector3.zero * localScale, duration);
    }

    #endregion
}

public enum ModalOpenType
{
    onlyOpen,
    animator,
    doTween
}

