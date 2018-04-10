using FirstMainWindow.model;
using FirstMainWindow.SecondView;
using FirstMainWindow.SecondViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FirstMainWindow.ViewModel
{
    public class MainWindowLogicClass : INotifyPropertyChanged
    {
        private bool selectionChange;

        public bool SelectionChange
        {
            get { return selectionChange; }
            set
            {
                if (selectionChange == value)
                    return;
                selectionChange = value;
                if (CurrentFilial != null)
                { AddCurrentSotr(CurrentFilial.FirmName); }
                OnPropertyChanged("SelectionChange");
            }
        }


        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value;OnPropertyChanged("Subject"); }
        }

        private string body;

        public string Body
        {
            get { return subject; }
            set { subject = value; OnPropertyChanged("Body"); }
        }


        private Sotrudnick currentSotrudnic;

        public Sotrudnick CurrentSotrudnic
        {
            get { return currentSotrudnic; }
            set { currentSotrudnic = value; OnPropertyChanged("CurrentSotrudnic"); }
        }


        private FilialClass currentFilial;

        public FilialClass CurrentFilial
        {
            get { return currentFilial; }
            set
            {
                currentFilial = value;
                if (CurrentFilial != null)
                { AddCurrentSotr(CurrentFilial.FirmName); }
                OnPropertyChanged("CurrentFilial"); }
        }


        private string firmname;

        public string Firmnames
        {
            get { return firmname; }
            set { firmname = value; OnPropertyChanged("Firmnames"); }
        }

        private string firmAddres;

        public string FirmAddress
        {
            get { return firmAddres; }
            set { firmAddres = value; OnPropertyChanged("FirmAddress"); }
        }

        private string countsotr;

        public string CountSotrs
        {
            get { return countsotr; }
            set { countsotr = value; OnPropertyChanged("CountSotrs"); }
        }

        private string emailSotr;

        public string EmailSotr
        {
            get { return emailSotr; }
            set { emailSotr = value; OnPropertyChanged("EmailSotr"); }
        }


        public ObservableCollection<Sotrudnick> AllSotrudniki = new ObservableCollection<Sotrudnick>();
        public ObservableCollection<FilialClass> Filials { get; set; } = new ObservableCollection<FilialClass>();
        public ObservableCollection<Sotrudnick> CurrentSotrudniki { get; set; } = new ObservableCollection<Sotrudnick>();
        public ObservableCollection<Sotrudnick> SelectedForSend { get; set; } = new ObservableCollection<Sotrudnick>();

        public void AddCurrentSotr(string firmNaem)
        {
            CurrentSotrudniki.Clear();
            foreach (var sotr in AllSotrudniki)
            {
                if (sotr.FilialName == firmNaem)
                    CurrentSotrudniki.Add(sotr);
            }
        }

       public ICommand AddFilial { get; set; }
       public ICommand AddSotr { get; set; }

        public ICommand SendMessage { get; set; }
        public MainWindowLogicClass()
        {
            AddFilial = new CommandClass(AddFilials,CanAddFilial);
            AddSotr = new CommandClass(AddSotrudnicov, CanAddSotrudnicov);
            SendMessage = new CommandClass(Send, CanSend);
        }

        private bool CanSend(object obj)
        {
            if(CurrentFilial!=null)
            {
                if(CurrentSotrudniki.Count>0)
                {
                    if ((Subject != null && Subject != "") && (Body != null && Body != ""))
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }

            return false;
        }
         
                

        private void Send(object obj)
        {
            var sotr = from x in AllSotrudniki where x.IsSelected == true select x;
            if(sotr.ToList().Count==0)
            {
                foreach(var email in CurrentSotrudniki)
                {
                    SendMethod(email.Email);
                }
            }
            else if(sotr.ToList().Count > 0)
            {
                SelectedForSend.Clear();
                var curemail = from x in CurrentSotrudniki where x.IsSelected == true select x;
                foreach(var item in curemail.ToList())
                {
                    SelectedForSend.Add(item);
                }
                foreach (var email in SelectedForSend)
                {
                    SendMethod(email.Email);
                }
            }
        }

        public void SendMethod(string emailaddres)
        {
            SmtpClient client;
            Attachment attach;
            MailMessage message;
            NetworkCredential user;
            user = new NetworkCredential("mynikname1987@gmail.com", "21102009");
            client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = user;
            client.EnableSsl = true;
            message = new MailMessage("mynikname1987@gmail.com", $"{emailaddres}", Subject, Body);
            //client.SendCompleted += new SendCompletedEventHandler(CompleatedEventHandler);
            client.SendAsync(message, null);
        }

        //private void CompleatedEventHandler(object sender, AsyncCompletedEventArgs e)
        //{
        //    if (e.Cancelled)
        //    {
        //        MessageBox.Show($"Canceled {e.UserState.ToString()}", "Message", MessageBoxButton.OK);
        //    }
        //    else if (e.Error != null)
        //    {
        //        MessageBox.Show($"Error {e.Error.ToString()} userstate - {e.UserState.ToString()}", "Message", MessageBoxButton.OK);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Succeful sending");
        //    }
        //}
        private bool CanAddFilial(object obj)
        {
            int count;
            if (int.TryParse(CountSotrs, out count))
            {
                if ((Firmnames != null && Firmnames != "") && (FirmAddress != null && FirmAddress != "") && (count != 0))
                {
                    return true;
                }
                //MessageBox.Show("Somting wrong in CanAddFilial");
                return false;
            }
            return false;
        }

        private void AddFilials(object obj)
        {
            Filials.Add(new FilialClass(Firmnames,FirmAddress,int.Parse(CountSotrs)));
        }

        private bool CanAddSotrudnicov(object obj)
        {
            if (Filials.Count > 0)
                return true;

            return false;
        }

        private void AddSotrudnicov(object obj)
        {
            CurrentFilial = null;
            AddSotrudnicWindow secondWindow = new AddSotrudnicWindow(Filials,AllSotrudniki);
            secondWindow.ShowDialog();
            AllSotrudniki = secondWindow.second.AallSotrudniki;
            secondWindow.Close();

           
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = null)
        {
            if (propertyName != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
