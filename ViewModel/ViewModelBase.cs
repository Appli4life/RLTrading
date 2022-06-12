using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListBoxMVVM.ViewModels
{
    /// <summary>
    /// Basisklasse für alle ViewModel
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Property

        /// <summary>
        /// Property Changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion

        #region Methoden

        /// <summary>
        /// SetProperty Methode 
        /// </summary>
        /// <typeparam name="T">Generisch</typeparam>
        /// <param name="storage">Das zu speichernde Property</param>
        /// <param name="value">Der Wert</param>
        /// <param name="property">Das Property das sich ändert (um das event auszulösen)</param>
        protected void SetProperty<T>(ref T storage, T value, [CallerMemberName] string property = null)
        {
            if (Object.Equals(storage, value)) return;
            storage = value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// OnPropertyChanged Methode
        /// </summary>
        /// <param name="propertyName">Property Name welches sich geändert hat</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
