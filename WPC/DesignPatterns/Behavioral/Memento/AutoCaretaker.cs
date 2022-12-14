using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Memento
{
    internal class AutoCaretaker<T> : Caretaker<T> where T : ICloneable, IRestorable<T>, INotifyPropertyChanged
    {
        public AutoCaretaker(T originator) : base(originator)
        {
            originator.PropertyChanged += Originator_PropertyChanged;
        }

        private void Originator_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            SaveState();
        }
    }
}
