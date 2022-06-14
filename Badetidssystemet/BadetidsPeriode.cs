using System;
using System.Collections.Generic;

namespace Badetidssystemet
{
    public class BadetidsPeriode
    {
        string _type;
        DayOfWeek _ugeDag;
        DateTime _startTidspunkt;
        DateTime _slutTidspunkt;
        Dictionary<string, Kreds> _kreds;


        public string Type
        {
            get { return _type; }
            set
            {
                if (value.Length < 4)
                    throw new ArgumentException("Type must have atleast 4 characters");
                _type = value;
            }
        }

        public DayOfWeek UgeDag
        {
            get { return _ugeDag; }
            set { _ugeDag = value; }
        }

        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set
            {
                if (value > _slutTidspunkt)
                    throw new ArgumentException("Start Date cannot be later than Slut Date");
                _slutTidspunkt = value;
            }
        }

        public DateTime SlutTidspunkt
        {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; }
        }


        public BadetidsPeriode(string Type, DayOfWeek UgeDag, DateTime StartTidspunkt, DateTime SlutTidspunkt)
        {
            _type = Type;
            _ugeDag = UgeDag;
            this._startTidspunkt = StartTidspunkt;
            this._slutTidspunkt = SlutTidspunkt;
            _kreds = new Dictionary<string, Kreds>();
        }

        public void AdderKreds(Kreds kreds)
        {
            _kreds.Add(kreds.ID, kreds);
        }

        public void DeleteKreds(Kreds kreds)
        {
            _kreds.Remove(kreds.ID);
        }

        public override string ToString()
        {
            return $"Type: {Type} - Uge Dag: {UgeDag} - Start Tidspunkt: {StartTidspunkt} - Slut Tidspunkt: {SlutTidspunkt}";
        }
    }
}
