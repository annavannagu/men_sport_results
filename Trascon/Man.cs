using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Trascon
{
    public class Man : INotifyPropertyChanged
    {
        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public Man()
        {
            
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        private uint _jump;
        public uint Jump
        {
            get { return _jump; }
            set
            {
                if (value == _jump) return;
                _jump = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Medal));
            }
        }

        private int _flex;
        public int Flex
        {
            get { return _flex; }
            set
            {
                if (value == _flex) return;
                _flex = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Medal));
            }
        }

        private uint _push;
        public uint Push
        {
            get { return _push; }
            set
            {
                if (value == _push) return;
                _push = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Medal));
            }
        }

        private int _medal;
        public int Medal
        {
            get { return _medal; }
            set
            {
                if (value == _medal) return;
                _medal = value;
                OnPropertyChanged();
            }
        }

        private int _group;
        public int Group
        {
            get { return _group; }
            set
            {
                if (value == _group) return;
                _group = value;                
            }
        }

        private int [] _arrRezult=new int [3];

        public int WhichMedal(Man man)
        {
            Results results = new Results();
            int[] jumpResult = results.GetJumpArr(man.Group);
            int[] flexResult = results.GetFlexArr(man.Group);
            int[] pushResult = results.GetPushArr(man.Group);

            #region Jump result
            if (man.Jump < jumpResult[0])
            {
                _arrRezult[0] = 0;
            }
            if (jumpResult[0] <= man.Jump && man.Jump < jumpResult[1])
            {
                _arrRezult[0] = 1;
            }
            if (jumpResult[1] <= man.Jump && man.Jump < jumpResult[2])
            {
                _arrRezult[0] = 2;
            }
            if (jumpResult[2] <= man.Jump)
            {
                _arrRezult[0] = 3;
            }
            #endregion

            #region Flexibility result
            if (man.Flex < flexResult[0])
            {
                _arrRezult[1] = 0;
            }
            if (flexResult[0] <= man.Flex && man.Flex < flexResult[1])
            {
                _arrRezult[1] = 1;
            }
            if (flexResult[1] <= man.Flex && man.Flex < flexResult[2])
            {
                _arrRezult[1] = 2;
            }
            if (flexResult[2] <= man.Flex)
            {
                _arrRezult[1] = 3;
            }
            #endregion

            #region Push up result
            if (man.Push < pushResult[0])
            {
                _arrRezult[2] = 0;
            }
            if (pushResult[0] <= man.Push && man.Push < pushResult[1])
            {
                _arrRezult[2] = 1;
            }
            if (pushResult[1] <= man.Push && man.Push < pushResult[2])
            {
                _arrRezult[2] = 2;
            }
            if (pushResult[2] <= man.Push)
            {
                _arrRezult[2] = 3;
            }
            #endregion

            return _arrRezult.Min();
        }
    }
}
