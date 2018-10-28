using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PotionCountdown : MonoBehaviour {

    TextMeshProUGUI countdownText;
    Color potionFaded;
    Color textFaded;
    Color potionFullColor;
    Color textFullColor;
    [SerializeField] RawImage potionImage;
    [SerializeField] CharacterController2D controller;
    [SerializeField] float additionnalJumpForce = 500f;

	// Use this for initialization
	void Start () {
        countdownText = GetComponent<TextMeshProUGUI>();
        potionFaded = new Color(255f, 255f, 255f, 0.3f);
        potionFullColor = new Color(255f, 255f, 255f, 255f);
        textFaded = new Color(0f, 0f, 0f, 0f);
        textFullColor = new Color(0f, 0f, 0f, 255f);
	}
	
    public void StartCountdown()
    {
        controller.m_JumpForce += additionnalJumpForce;
        potionImage.color = potionFullColor;
        countdownText.color = textFullColor;
        StartCoroutine("Countdown");
    }

    private IEnumerator Countdown()
    {
        float duration = 15f;
        float totalTime = 0;
        while (totalTime <= duration)
        {
            totalTime += Time.deltaTime;
            var timeLeft = (int)duration - (int)totalTime;
            countdownText.text = timeLeft.ToString("D2");
            yield return null;
        }
        countdownText.color = textFaded;
        potionImage.color = potionFaded;
        controller.m_JumpForce -= additionnalJumpForce;
    }
}
