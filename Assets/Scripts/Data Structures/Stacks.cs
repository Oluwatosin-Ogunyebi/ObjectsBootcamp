using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stacks : MonoBehaviour
{
    Stack<string> actions = new Stack<string>();
    Queue<string> people = new Queue<string>();

    Dictionary<string, int> weapons = new Dictionary<string, int>();
    private void Start()
    {
        actions.Push("walk");
        actions.Push("jump");
        actions.Push("run");

        Debug.Log($"The number of actions are {actions.Count}");

        people.Enqueue("Josh");
        people.Enqueue("Akshay");
        people.Enqueue("Daniel");
        people.Enqueue("Albert");
        people.Enqueue("Charles");

        weapons.Add("knife", 10);
        weapons.Add("guns", 5);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //var lastActionAvailable =  actions.Peek();
            // Debug.Log($"The last action was {lastActionAvailable} and the number of actions left are {actions.Count}");
            // var lastAction = actions.Pop();
            // Debug.Log($"The last action was {lastAction} and the number of actions left are {actions.Count}");

            //var personAttendedto = people.Dequeue();
            //Debug.Log($"The person we are attending to is {personAttendedto} and there a {people.Count} left on the queue");

            Debug.Log($"THe number of knives are {weapons["knife"]}");
        }

    }
}
