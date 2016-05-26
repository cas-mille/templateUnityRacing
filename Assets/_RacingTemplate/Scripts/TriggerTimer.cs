using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerTimer : MonoBehaviour {

	public GameObject timerTarget;
	public Text timerText;
	public Text bestText;

	private float time;
	private float timer;
	private float startTime;
	private float best;

	void Start () {	
		best = 10f;
	}
	
	void FixedUpdate () {

		time += Time.deltaTime;
		timer = time - startTime;

		timerText.text = timer.ToString("0.00");
		bestText.text = "best: " + best.ToString("0.00");

	}

	void OnTriggerEnter(Collider other) {

		if (other.CompareTag("TimerTarget")){
			if (timer < best) {
				best = timer;
			}
			startTime = time;
		}

	}
}
