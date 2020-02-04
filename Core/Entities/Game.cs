using System.Linq;

namespace Core.Entities
{
    public class Game
    {
        public Pump[] Pumps { get; }
        public Valve[] Valves { get; }
        public Line[] Lines { get; }

        public Game()
        {
            // create 2 pumps
            Pumps = Enumerable.Range(0, 2).Select(x => new Pump()).ToArray();
            Valves = Enumerable.Range(0, 29).Select(x => new Valve()).ToArray();
            Lines = Enumerable.Range(0, 33).Select(x => new Line()).ToArray();

            SetupRules();
        }

        private void SetupRules()
        {
            Pumps[1].StateChanged += (state) =>
            {
                if (
                    state == NewPumpState.Active &&
                    Valves[1].State == NewValveState.Active &&
                    Valves[15].State == NewValveState.Active &&
                    Valves[16].State == NewValveState.Active &&
                    Lines[25].State == NewLineState.Active && 
                    Valves[4].State == NewValveState.Passive)
                {
                    //circ += 1;
                }
            };

            Valves[1].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Valves[15].State == NewValveState.Active &&
                    Valves[16].State == NewValveState.Active &&
                    Lines[25].State == NewLineState.Active &&
                    Valves[4].State == NewValveState.Passive &&
                    Pumps[1].State == NewPumpState.Passive)
                {
                    //1
                    //circ += 1;
                }
            };


            Valves[4].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Valves[1].State == NewValveState.Active &&
                    Valves[15].State == NewValveState.Active &&
                    Valves[16].State == NewValveState.Active &&
                    Lines[25].State == NewLineState.Active &&
                    Pumps[1].State == NewPumpState.Active)
                {
                    //3
                    //circ += 1;
                }
            };

            Valves[13].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Valves[8].State == NewValveState.Passive &&
                    Valves[0].State == NewValveState.Active &&
                    Lines[6].State == NewLineState.Active)
                {
                    Lines[15].ToggleState();
                    Lines[17].ToggleState();
                }

                if (
                    state == NewValveState.Active &&
                    Valves[8].State == NewValveState.Active &&
                    Lines[6].State == NewLineState.Active &&
                    Valves[5].State == NewValveState.Passive && 
                    Valves[11].State == NewValveState.Passive &&
                    Valves[21].State == NewValveState.Passive
                    )
                {
                    Lines[11].ToggleState();
                    Lines[15].ToggleState();
                    Lines[17].ToggleState();
                    Lines[19].ToggleState();
                    Lines[22].ToggleState();
                }
            };

            Valves[19].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Valves[10].State == NewValveState.Active)
                {
                    //Lines[8].ToggleState();
                    //Lines[9].ToggleState();
                }
            };

            Valves[16].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Valves[15].State == NewValveState.Active && 
                    Lines[24].State == NewLineState.Active)
                {
                    Lines[25].ToggleState();
                    Lines[26].ToggleState();
                }
            };

            Valves[18].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Valves[10].State == NewValveState.Active &&
                    Lines[8].State == NewLineState.Active &&
                    Lines[11].State == NewLineState.Active &&
                    Valves[19].State == NewValveState.Passive &&
                    Valves[20].State == NewValveState.Passive &&
                    Valves[21].State == NewValveState.Passive
                )
                {
                    Lines[8].ToggleState();
                    Lines[9].ToggleState();
                    Lines[13].ToggleState();
                    Lines[14].ToggleState();
                }
            };

            Valves[21].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Valves[3].State == NewValveState.Active &&
                    Valves[10].State == NewValveState.Active &&
                    Valves[18].State == NewValveState.Active &&
                    Lines[11].State == NewLineState.Active &&
                    Valves[16].State == NewValveState.Passive &&
                    Valves[19].State == NewValveState.Passive &&
                    Valves[20].State == NewValveState.Passive
                )
                {
                    Lines[10].ToggleState();
                    Lines[23].ToggleState();
                    Lines[24].ToggleState();
                    Lines[8].ToggleState();
                    Lines[9].ToggleState();
                    Lines[13].ToggleState();
                    Lines[14].ToggleState();
                }
            };

            Valves[0].StateChanged += (state) =>
            {
                if (
                    state == NewValveState.Active &&
                    Pumps[0].State == NewPumpState.Active &&
                    Valves[2].State == NewValveState.Active &&
                    Valves[10].State == NewValveState.Active &&
                    Valves[19].State == NewValveState.Active &&
                    Valves[20].State == NewValveState.Active &&
                    Valves[1].State == NewValveState.Passive &&
                    Valves[5].State == NewValveState.Passive &&
                    Valves[13].State == NewValveState.Passive &&
                    Valves[18].State == NewValveState.Passive &&
                    Valves[21].State == NewValveState.Passive
                )
                {
                    Lines[0].ToggleState();
                    Lines[1].ToggleState();
                    Lines[2].ToggleState();
                    Lines[3].ToggleState();
                    Lines[4].ToggleState();
                    Lines[5].ToggleState();
                    Lines[6].ToggleState();
                    Lines[7].ToggleState();
                    Lines[8].ToggleState();
                    Lines[9].ToggleState();
                    Lines[12].ToggleState();
                    Lines[13].ToggleState();
                    Lines[14].ToggleState();
                }
            };
        }

    }
}