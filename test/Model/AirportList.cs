using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab7;

namespace lab7
{
    public class AirportList
    {
        public List<Airport> Hubs { get; set; } = new List<Airport>();

        public int Length { get; set; } = 0;

        public delegate void MessageListener(string message);

        public event MessageListener Listener = message => MessageBox.Show(message);

        public AirportList()
        {
            Hubs = new List<Airport>();
            Length = 0;
        }

        public AirportList(List<Airport> hub)
        {
            foreach (var i in hub)
            {
                Hubs.Add(i);
            }
            Length = hub.Count;
        }

        public Airport this[int index]
        {
            get => Hubs[index];
            set => Hubs[index] = value;
        }

        public void Add(Airport hub)
        {
            Hubs.Add(hub);
            Listener?.Invoke($"Добавлен: {hub.Name}");
            Length++;
        }

        public Airport Remove(string hubName)
        {
            var hub = Hubs.FirstOrDefault(x => x.Name.ToLower() == hubName.ToLower());

            if (hub != null)
            {
                Hubs.Remove(hub);
                Listener?.Invoke($"Удалён: {hub.Name}");
                Length--;

                return hub;
            }

            return null;
        }
    }
}
