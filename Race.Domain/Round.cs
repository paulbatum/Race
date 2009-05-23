using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public class Round
    {
        private readonly Game _game;
        private Queue<RoundStep> _steps;

        public Round(Game game)
        {
            _game = game;

            _steps = new Queue<RoundStep>();
            _steps.Enqueue(new ActionsStep(_game));
        }

        public void Begin()
        {
            ProcessNextStep();
        }

        private void ProcessNextStep()
        {
            if(_steps.Count == 0)
                return;

            var currentStep = _steps.Dequeue();
            currentStep.Execute(() => ProcessNextStep());

        }

        private abstract class RoundStep
        {
            protected Game _game;
            public abstract void Execute(Action onCompletedCallback);

            protected RoundStep(Game game)
            {
                _game = game;
            }
        }

        private class SelectActionsStep : RoundStep
        {
            public SelectActionsStep(Game game) : base(game)
            {
            }

            public override void Execute(Action onCompletedCallback)
            {
                _game.DoInteraction(new SelectActionsInteraction(onCompletedCallback));
            }
        }

        private class DoActionsStep : RoundStep
        {
            public DoActionsStep(Game game) : base(game)
            {
            }

            public override void Execute(Action onCompletedCallback)
            {
                throw new NotImplementedException();
            }
        }

        private class DiscardStep : RoundStep
        {
            public DiscardStep(Game game) : base(game)
            {
            }

            public override void Execute(Action onCompletedCallback)
            {
                throw new NotImplementedException();
            }
        }
         
    }

    public interface IInteraction
    {
        
    }
}