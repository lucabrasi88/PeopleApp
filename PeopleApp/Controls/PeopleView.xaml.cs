using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml.Linq;
using PeopleApp.Constants;
using PeopleApp.Model;
using PeopleApp.ViewModel;

namespace PeopleApp.Controls
{
    /// <summary>
    /// Interaction logic for PeopleView.xaml
    /// </summary>
    public partial class PeopleView : UserControl
    {
        public PeopleView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves persons data to xml file
        /// </summary>
        /// <returns>XElement</returns>
        private XElement SavePersonsToXml()
        {
            ObservableCollection<Person> person =
                ((PeopleDataViewModel) ((ObjectDataProvider) FindResource("peopleDG")).Data).Persons;
            XElement personElement =
                new XElement(ConstNames.XmlFileRootName,
                    person.Select(persons =>
                        new XElement(ConstNames.XmlFileElementName,
                            new XElement(ConstNames.FirstName, persons.FirstName),
                            new XElement(ConstNames.LastName, persons.LastName),
                            new XElement(ConstNames.StreetName, persons.StreetName),
                            new XElement(ConstNames.HouseNumber, persons.HouseNumber),
                            new XElement(ConstNames.ApartmentNumber, persons.ApartmentNumber),
                            new XElement(ConstNames.PostalCode, persons.PostalCode),
                            new XElement(ConstNames.PhoneNumber, persons.PhoneNumber),
                            new XElement(ConstNames.DayOfBirth, persons.DayOfBirth),
                            new XElement(ConstNames.Age, persons.Age))));
            return personElement;
        }

        /// <summary>
        /// Saves data to xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveData(object sender, RoutedEventArgs e)
        {
            XElement savePersonsXml = SavePersonsToXml();
            savePersonsXml.Save(ConstNames.XmlFileName);
        }

        /// <summary>
        /// Sets age value depending on DatePicker value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePicker_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? dateTimeTemp = (DateTime?)e.AddedItems[0];

            DatePicker datePicker = (DatePicker)sender;
            DataGridRow row = (DataGridRow)PeopleDataGrid.ContainerFromElement(datePicker);
            Person gridModel = (Person)PeopleDataGrid.Items[row.GetIndex()];
            gridModel.Age = (DateTime.Now.Year - dateTimeTemp.Value.Year).ToString();
        }
    }
}
