﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGisBLL
{
    public class Map: IMap
    {
        private string _name = string.Empty;
        List<ILayer>_layers = new List<ILayer>();
        Dictionary<string, ILayer> layerDict = new Dictionary<string, ILayer>();

        private int _layerCount = 0;
        

        string IMap.Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        List<ILayer>  IMap.Layers
        {
            get { return _layers; }
        }

        int IMap.LayerCount
        {
            get
            {
                return _layerCount;
            }
        }

        void IMap.AddLayer(ILayer layer)
        {

            _layers.Add(layer);
        }

        void IMap.RemoveLayer(int index)
        {
            for (int i = 0; i < _layers.Count; i++)
            {
                if (i < index)
                    _layers[i] = _layers[i];
                if (i > index)
                    _layers[i - 1] = _layers[i];
            }
            
            _layerCount--;
        }
    }
}