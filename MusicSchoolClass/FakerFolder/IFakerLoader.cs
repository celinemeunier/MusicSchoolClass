using System.Collections.Generic;

namespace MusicSchoolClass.FakerFolder
{
    public interface IFakerLoader<T>
    {
        T LoadSingleItem();
        List<T> LoadMultipleItems();
    }
}
