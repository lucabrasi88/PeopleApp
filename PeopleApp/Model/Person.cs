using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using PeopleApp.Constants;

namespace PeopleApp.Model
{
    /// <summary>
    /// Keeps fields for particular person data
    /// </summary>
    [Serializable]
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _streetName;
        private string _houseNumber;
        private string _apartmentNumber;
        private string _postalCode;
        private string _phoneNumber;
        private string _dayOfBirth;
        private string _age;

        public event PropertyChangedEventHandler PropertyChanged;


        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }


        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }


        public string StreetName
        {
            get { return _streetName; }
            set
            {
                _streetName = value;
                NotifyPropertyChanged("StreetName");
            }
        }


        public string HouseNumber
        {
            get { return _houseNumber; }
            set
            {
                _houseNumber = value;
                NotifyPropertyChanged("HouseNumber");
            }
        }


        public string ApartmentNumber
        {
            get { return _apartmentNumber; }
            set
            {
                _apartmentNumber = value;
                NotifyPropertyChanged("ApartmentNumber");
            }
        }


        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                _postalCode = value;
                NotifyPropertyChanged("PostalCode");
            }
        }


        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                NotifyPropertyChanged("PhoneNumber");
            }
        }


        public string DayOfBirth
        {
            get { return _dayOfBirth; }
            set
            {
                _dayOfBirth = value;
                NotifyPropertyChanged("DayOfBirth");
            }
        }


        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                NotifyPropertyChanged("Age");
            }
        }

        #region Validation

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();

                // iterate over all of the properties
                // of this object - aggregating any validation errors
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {
                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }

                // apply object level validation rules
                if (DayOfBirth.CompareTo(DateTime.Now) > 0)
                {
                    error.Append((error.Length != 0 ? ", " : "") +
                                  "EndTime must be after StartTime");
                }

                return error.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                // apply property level validation rules
                if (columnName != ConstNames.ApartmentNumber && columnName != ConstNames.Age)
                {
                    if (string.IsNullOrEmpty(FirstName) || !Regex.IsMatch(PhoneNumber, @"^[a-zA-Z]+$"))
                        return Resources.FirstNameValidationText;
                    if (string.IsNullOrEmpty(LastName) || !Regex.IsMatch(PhoneNumber, @"^[a-zA-Z]+$"))
                        return Resources.LastNameValidationText;
                    if (string.IsNullOrEmpty(HouseNumber))
                        return Resources.HouseNumberValidationText;
                    if (string.IsNullOrEmpty(StreetName))
                        return Resources.StreetNameValidationText;
                    if (string.IsNullOrEmpty(PostalCode))
                        return Resources.PostalCodeValidationText;
                    if (string.IsNullOrEmpty(PhoneNumber) || !Regex.IsMatch(PhoneNumber, "^[0-9]*$"))
                        return Resources.PhoneNumberValidationText;
                    if (string.IsNullOrEmpty(DayOfBirth))
                        return Resources.DayOfBirthValidationText;
                }

                return "";
            }
        }

        #endregion

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
