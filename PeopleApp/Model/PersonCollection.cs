using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using PeopleApp.Constants;

namespace PeopleApp.Model
{
    [Serializable]
    [XmlRoot(ConstNames.XmlFileRootName)]
    public class PersonCollection : ObservableCollection<Person>
    {

    }
}
