using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Xml.Linq;
using System.Xml.Serialization;
using PeopleApp.Annotations;
using PeopleApp.CommandBinding;
using PeopleApp.Constants;
using PeopleApp.Model;

namespace PeopleApp.ViewModel
{
    /// <summary>
    /// View model for people data 
    /// </summary>
    public class PeopleDataViewModel : INotifyPropertyChanged
    {
        private PersonCollection _persons;

        public ICommand RestoreCommand { get { return new RelayCommand(RestoreData, CanRestoreData); } }       

        private bool CanRestoreData()
        {
            return true;
        }

        /// <summary>
        /// Restores saved data
        /// </summary>
        private void RestoreData()
        {
           GetPersonsFromXml();
        }

        /// <summary>
        /// Gets persons data from xml file
        /// </summary>
        private void GetPersonsFromXml()
        {
            Persons.Clear();
            XElement persons = XElement.Load(ConstNames.XmlFileName);
            var personElements = persons.Elements(ConstNames.XmlFileElementName);
            foreach (XElement person in personElements)
            {
                
                Persons.Add( new Person
                {
                    FirstName = (string)person.Element(ConstNames.FirstName),
                    LastName = (string)person.Element(ConstNames.LastName),
                    StreetName = (string)person.Element(ConstNames.StreetName),
                    HouseNumber = (string)person.Element(ConstNames.HouseNumber),
                    ApartmentNumber = (string)person.Element(ConstNames.ApartmentNumber),
                    PostalCode = (string)person.Element(ConstNames.PostalCode),
                    PhoneNumber = (string)person.Element(ConstNames.PhoneNumber),
                    DayOfBirth = (string)person.Element(ConstNames.DayOfBirth),
                    Age = (string)person.Element(ConstNames.Age),
                });
            }

        }

        private bool CanSaveData()
        {
            return true;
        }

        /// <summary>
        /// Initializes the view model
        /// </summary>
        public PeopleDataViewModel()
        {
            _persons = new PersonCollection();
            GetPersonsFromXml();
        }

        public PersonCollection Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
