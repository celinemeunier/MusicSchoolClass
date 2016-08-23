using MusicSchoolClass.FakerFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MusicSchoolClass.Base
{
    public class EntityBase : INotifyPropertyChanged, IFakerLoader<EntityBase>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<EntityBase> LoadMultipleItems()
        {
            List<EntityBase> result = new List<EntityBase>();
            for (int i = 0; i < Faker.Number.RandomNumber(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }

            return result;
        }



        public EntityBase LoadSingleItem()
        {
            return null; 
        }


        public void OnPropertyChanged(String name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

