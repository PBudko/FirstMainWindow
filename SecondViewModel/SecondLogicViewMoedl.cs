using FirstMainWindow.model;
using FirstMainWindow.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstMainWindow.SecondViewModel
{

  public class SecondLogicViewMoedl : INotifyPropertyChanged
    {
        


        public SecondLogicViewMoedl()
        {
            AddEmail = new CommandClass(AddSotr, CanAdd);
            RemoveEmail = new CommandClass(Remove,CanRemove);
        }

        private string email;
        public string CurrentEmail
        {
            get { return email; }
            set { email = value;OnPropertyChanged("CurrentEmail"); }
        }

        private Sotrudnick currentSotr;

        public Sotrudnick CurrentSotr
        {
            get { return currentSotr; }
            set { currentSotr = value; OnPropertyChanged("CurrentSotr"); }
        }



        public ICommand RemoveEmail { get; set; }
        public bool CanRemove(object obj)
        {
            if (CurrentSotrudniki.Count!=0)
            {
                var sotr = from x in CurrentSotrudniki where x.IsSelected == true select x;
                if ((sotr.ToList()).Count >0)
                {
                    foreach(var item in sotr.ToList())
                    {
                        RemoveSotrudniki.Add(item);
                    }
                    return true;
                }
                return false;
            }
            return false;
        }
        public void Remove(object obj)
        {
            var sotr = from x in CurrentSotrudniki where x.IsSelected == true select x;
            if ((sotr.ToList()).Count > 0)
            {
                foreach (var item in sotr.ToList())
                {
                    RemoveSotrudniki.Add(item);
                }
            }
                foreach (var sotrs in RemoveSotrudniki)
            {
                var f = sotrs;
                CurrentSotrudniki.Remove(sotrs);
                AallSotrudniki.Remove(f);
                
            }
        }


        public ICommand AddEmail { get; set; } 
        public bool CanAdd(object obj)
        {
            if (CurrentEmail != "" && CurrentEmail != null)
            {
                var sotr = from x in AallSotrudniki where x.FilialName == CurrentFilial.FirmName select x;
                if ((sotr.ToList()).Count < CurrentFilial.CountSotr)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public void AddSotr(object obj)
        {
            var sotr = new Sotrudnick(CurrentEmail, CurrentFilial.FirmName);
            AallSotrudniki.Add(sotr);
            CurrentSotrudniki.Add(sotr);
        }


        public ObservableCollection<FilialClass> Filials { get; set; } = new ObservableCollection<FilialClass>();
        public ObservableCollection<Sotrudnick> AallSotrudniki { get; set; } = new ObservableCollection<Sotrudnick>();
        public ObservableCollection<Sotrudnick> CurrentSotrudniki { get; set; } = new ObservableCollection<Sotrudnick>();
        public ObservableCollection<Sotrudnick> RemoveSotrudniki { get; set; } = new ObservableCollection<Sotrudnick>();


        private FilialClass currentFilial;
    public FilialClass CurrentFilial
    {
        get { return currentFilial; }
        set {
                currentFilial = value;
                OnPropertyChanged("CurrentFilial");
                CurrentSotrudniki.Clear();
                foreach (var sotr in (from x in AallSotrudniki where x.FilialName == CurrentFilial.FirmName select x))
                { CurrentSotrudniki.Add(sotr); }
            }
    }



    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(string propertyname)
    {
        if (propertyname != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
 }
}

