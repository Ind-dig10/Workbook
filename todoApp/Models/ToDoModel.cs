using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoApp.Models
{
    class ToDoModel: INotifyPropertyChanged
    {
        public DateTime CreaDate { get; set; } = DateTime.Now;

        private bool MyVar;
        private string _text;

      
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool IsDone
        {
            get { return MyVar; }
            set
            {
                if (MyVar == value) return;
                OnPropertyChanged("IsDone");
                MyVar = value;
                
            }
        }

        public string Text
        {
            get { return _text; }
            set {
                if (_text == value) return;
                
                _text = value;
                OnPropertyChanged("Text");
            }
        }
    }
}
