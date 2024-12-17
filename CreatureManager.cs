using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assignment26 {
    
   public class Creature {

        public virtual void Speak()
        {
            Console.WriteLine("A creature makes a sound.");
        }
    }

    public interface IRunnable
    {
        void Run();
    }

    public interface IJumpable
    {
        void Jump();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Kangaroo : Creature, IRunnable, IJumpable{
    
        public void Run() { Debug.Log("Kangaroo runs."); }
        public void Jump() { Debug.Log("Kangaroo jumps."); }
        public override void Speak() { Debug.Log("Duck says: Quack!"); }
    }

    public class Duck : Creature, IRunnable, ISwimmable {

        public void Run() { Debug.Log("Duck runs."); }
        public void Swim() { Debug.Log("Duck swims."); }
        public override void Speak() { Debug.Log("Duck says: Quack!"); }
    }



    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> list = new List<Creature>();
            List<IRunnable> runnables = new List<IRunnable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();
            List<IJumpable> jumpables = new List<IJumpable>();

            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            list.Add(duck);
            list.Add(kangaroo);

            runnables.Add(kangaroo);
            runnables.Add(duck);

            jumpables.Add(kangaroo);
            swimmables.Add(duck);

            foreach (Creature creature in list) { creature.Speak(); }
            foreach (IRunnable runnable in runnables) { runnable.Run(); }
            foreach (ISwimmable swimmable in swimmables) { swimmable.Swim(); }
            foreach (IJumpable jumpable in jumpables) { jumpable.Jump(); }



        }
        void Update()
        {

        }
    }

}



