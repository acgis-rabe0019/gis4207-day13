using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGisBLL
{
    public class MapDocument:IMapDocument, IMapManager
    {
        private IMap _focusMap = new Map();
        private List<IMap> _maps = new List<IMap>();
        private Dictionary<string, IMap> mapDict = new Dictionary<string, IMap>();
        
        IMap IMapDocument.FocusMap
        {
            get { return _focusMap; }
        }

        List<IMap> IMapDocument.Maps
        {
            get {return _maps;}               
        }

        IMap IMapDocument.GetMap(string name)
        {
            for (int i = 0; i < _maps.Count; i++)
            {
                if (_maps[i].Name == name)
                    return _maps[i];
            }
            return null;
        }

        void IMapManager.AddMap(IMap map)
        {
            _maps.Add(map);
            mapDict.Add(map.Name, map);
        }

        void IMapManager.RemoveMap(int index)
        {
                
            _maps.Remove(_maps[index]);
            mapDict.Remove(_maps[index].Name);
        }    

        void IMapManager.SetFocusMap(int index)
        {
            _focusMap = _maps[index];
        }
    }
}
