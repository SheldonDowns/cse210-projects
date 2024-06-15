using System;

namespace ActivityApp
{
    class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void RunActivity()
        {
            int secondsPassed = 0;
            while (secondsPassed < Duration)
            {
                PauseWithAnimation("Breathe in...", 3);
                secondsPassed += 3;
                if (secondsPassed >= Duration) break;
                PauseWithAnimation("Breathe out...", 3);
                secondsPassed += 3;
            }
        }
    }
}
