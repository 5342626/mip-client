// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by the Game Data Editor.
//
//      Changes to this file will be lost if the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections.Generic;

using GameDataEditor;

namespace GameDataEditor
{
    public class GDEeventsData : IGDEData
    {
        private static string inttestKey = "inttest";
		private int _inttest;
        public int inttest
        {
            get { return _inttest; }
            set {
                if (_inttest != value)
                {
                    _inttest = value;
                    GDEDataManager.SetInt(_key+"_"+inttestKey, _inttest);
                }
            }
        }

        private static string nameKey = "name";
		private string _name;
        public string name
        {
            get { return _name; }
            set {
                if (_name != value)
                {
                    _name = value;
                    GDEDataManager.SetString(_key+"_"+nameKey, _name);
                }
            }
        }

        public GDEeventsData()
		{
			_key = string.Empty;
		}

		public GDEeventsData(string key)
		{
			_key = key;
		}
		
        public override void LoadFromDict(string dataKey, Dictionary<string, object> dict)
        {
            _key = dataKey;

			if (dict == null)
				LoadFromSavedData(dataKey);
			else
			{
                dict.TryGetInt(inttestKey, out _inttest);
                dict.TryGetString(nameKey, out _name);
                LoadFromSavedData(dataKey);
			}
		}

        public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			
            _inttest = GDEDataManager.GetInt(_key+"_"+inttestKey, _inttest);
            _name = GDEDataManager.GetString(_key+"_"+nameKey, _name);
         }

        public void Reset_inttest()
        {
            GDEDataManager.ResetToDefault(_key, inttestKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(inttestKey, out _inttest);
        }

        public void Reset_name()
        {
            GDEDataManager.ResetToDefault(_key, nameKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(nameKey, out _name);
        }

        public void ResetAll()
        {
            GDEDataManager.ResetToDefault(_key, inttestKey);
            GDEDataManager.ResetToDefault(_key, nameKey);


            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            LoadFromDict(_key, dict);
        }
    }
}
