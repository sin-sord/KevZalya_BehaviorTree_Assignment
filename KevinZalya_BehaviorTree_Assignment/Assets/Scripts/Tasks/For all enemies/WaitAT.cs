using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.UI;


namespace NodeCanvas.Tasks.Actions {

	public class WaitAT : ActionTask {

        public BBParameter<Transform> currentTarget;
        public float time;
        public float maxTime;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			agent.transform.LookAt(currentTarget.value.position);
			time += Time.deltaTime;
			if(time >= maxTime)
			{
				time = 0;

                EndAction(true);
			}
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}