using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Trascon.Models;
using System.Windows.Data;
using Trascon.Cmds;
using System.Collections.Specialized;
using System.IO;
using System.Xml.Serialization;

namespace Trascon
{
    public class MainVM: INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        private ObservableCollection<Man> _Men { get; set; }
        public ObservableCollection<Man> Men
        {
            get { return _Men; }
            set
            {
                _Men = value;
                OnPropertyChanged(nameof(Men));                
            }
        }
        
        private readonly List<Man> _men;
        
        public MainVM()
        {
            ////список мужчин из Excel
            //MenMainList mainList = new MenMainList();
            //_men = mainList.GetAll();

            //список мужчин из XML
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Man>));
            using (Stream fStream = new FileStream("MenCollection.xml", FileMode.Open))
            {
                _men = (List<Man>)xmlFormat.Deserialize(fStream);
            }

            Men = new ObservableCollection<Man>(_men);            
        }


        private ICommand _AddCommand = null;
        public ICommand AddCommand => _AddCommand ?? (_AddCommand = new RelayCommand(AddMenWindow));     

        public void AddMenWindow ()
        {
            //новое окно с вводом данных нового человека
            NewMan manWindow = new NewMan();            
            if (manWindow.ShowDialog()==true)
            {
                if (manWindow.ResponseName != "" && 6 <= manWindow.ResponseGroup && manWindow.ResponseGroup <= 11)
                {
                    Men.Add(
                new Man
                {
                    Name = manWindow.ResponseName,
                    Group = manWindow.ResponseGroup,
                    Medal = -1
                });
                }
            }
        }

        public void SaveToXML()
        {
            using (Stream fStream = new FileStream("MenCollection.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(ObservableCollection<Man>));
                xmlFormat.Serialize(fStream, Men);
            }            
        }         
    }

    
}
