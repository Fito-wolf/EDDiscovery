﻿using EDDiscovery.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDDiscovery2
{
    public class EDDConfig
    {
        private static EDDConfig _instance;
        public static EDDConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EDDConfig();
                }
                return _instance;
            }
        }

        private bool _useDistances;
        private bool _EDSMLog;
        readonly public string LogIndex;
        private bool _canSkipSlowUpdates = false;
        public List<EDCommander> listCommanders;
        private int currentCmdrID=0;
        private Dictionary<string, object> settings = new Dictionary<string, object>();
        private Dictionary<string, Func<object>> defaults = new Dictionary<string, Func<object>>
        {
            { "Netlogdir", () => System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Frontier_Developments", "Products") },
            { "NetlogDirAutoMode", () => true },
        };

        SQLiteDBClass _db = new SQLiteDBClass();

        private EDDConfig()
        {
            LogIndex = DateTime.Now.ToString("yyyyMMdd");
        }

        public bool UseDistances
        {
            get
            {
                return _useDistances;
            }

            set
            {
                _useDistances = value;
                _db.PutSettingBool("EDSMDistances", value);
            }
        }

        public int CurrentCmdrID
        {
            get
            {
                return CurrentCommander.Nr;
            }

            set
            {
                var cmdr = listCommanders.Select((c, i) => new { index = i, cmdr = c }).SingleOrDefault(a => a.cmdr.Nr == value);
                if (cmdr != null)
                {
                    currentCmdrID = cmdr.index;
                    _db.PutSettingInt("ActiveCommander", value);
                }
            }
        }

        public EDCommander CurrentCommander
        {
            get
            {
                if (listCommanders == null)
                    Update();

                if (currentCmdrID >= listCommanders.Count)
                    currentCmdrID = listCommanders.Count - 1;


                return listCommanders[currentCmdrID];
            }
        }

        public bool EDSMLog
        {
            get
            {
                return _EDSMLog;
            }

            set
            {
                _EDSMLog = value;
                _db.PutSettingBool("EDSMLog", value);
            }
        }

        public bool CanSkipSlowUpdates
        {
            get
            {
                return _canSkipSlowUpdates;
            }
            set
            {
                _canSkipSlowUpdates = value;
                _db.PutSettingBool("CanSkipSlowUpdates", value);
            }
        }

        public string NetLogDir { get { return GetSettingString("Netlogdir"); } set { PutSettingString("Netlogdir", value); } }
        public bool NetLogDirAutoMode { get { return GetSettingBool("NetlogDirAutoMode"); } set { PutSettingBool("NetlogDirAutoMode", value); } }

        private bool GetSettingBool(string key)
        {
            return GetSetting<bool>(key, _db.GetSettingBool);
        }

        private int GetSettingInt(string key)
        {
            return GetSetting<int>(key, _db.GetSettingInt);
        }

        private double GetSettingDouble(string key)
        {
            return GetSetting<double>(key, _db.GetSettingDouble);
        }

        private string GetSettingString(string key)
        {
            return GetSetting<string>(key, _db.GetSettingString);
        }

        private T GetSetting<T>(string key, Func<string,T,T> getter)
        {
            if (!settings.ContainsKey(key))
            {
                settings[key] = getter(key, (T)defaults[key]());
            }

            return (T)settings[key];
        }

        private bool PutSettingBool(string key, bool value)
        {
            return PutSetting<bool>(key, value, _db.PutSettingBool);
        }

        private bool PutSettingInt(string key, int value)
        {
            return PutSetting<int>(key, value, _db.PutSettingInt);
        }

        private bool PutSettingDouble(string key, double value)
        {
            return PutSetting<double>(key, value, _db.PutSettingDouble);
        }

        private bool PutSettingString(string key, string value)
        {
            return PutSetting<string>(key, value, _db.PutSettingString);
        }

        private bool PutSetting<T>(string key, T value, Func<string,T,bool> setter)
        {
            settings[key] = value;
            return setter(key, value);
        }

        public void Update()
        {
            try
            {
                _useDistances = _db.GetSettingBool("EDSMDistances", false);
                _EDSMLog = _db.GetSettingBool("EDSMLog", false);
                _canSkipSlowUpdates = _db.GetSettingBool("CanSkipSlowUpdates", false);
                LoadCommanders();
                int activecommander = _db.GetSettingInt("ActiveCommander", 0);
                var cmdr = listCommanders.Select((c, i) => new { index = i, cmdr = c }).SingleOrDefault(a => a.cmdr.Nr == activecommander);
                if (cmdr != null)
                {
                    currentCmdrID = cmdr.index;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("EDDConfig.Update()" + ":" + ex.Message);
                System.Diagnostics.Trace.WriteLine(ex.StackTrace);
            }

        }

        private void LoadCommanders()
        {
            if (listCommanders == null)
                listCommanders = new List<EDCommander>();

            listCommanders.Clear();

            // Migrate old settigns.
            string apikey =  _db.GetSettingString("EDSMApiKey", "");
            string commanderName =  _db.GetSettingString("CommanderName", "");

           
           

            EDCommander cmdr = new EDCommander(0, _db.GetSettingString("EDCommanderName0", commanderName),  _db.GetSettingString("EDCommanderApiKey0", apikey));
            cmdr.NetLogPath = _db.GetSettingString("EDCommanderNetLogPath0", null);
            listCommanders.Add(cmdr);


            for (int ii = 1; ii < 100; ii++)
            {
                cmdr = new EDCommander(ii, _db.GetSettingString("EDCommanderName"+ii.ToString(), ""), _db.GetSettingString("EDCommanderApiKey" + ii.ToString(), ""));
                cmdr.NetLogPath = _db.GetSettingString("EDCommanderNetLogPath" + ii.ToString(), null);
                if (!cmdr.Name.Equals(""))
                    listCommanders.Add(cmdr);
            }

        }

        public void StoreCommanders(List<EDCommander> dictcmdr)
        {
            foreach (EDCommander cmdr in dictcmdr)
            {
                _db.PutSettingString("EDCommanderName" + cmdr.Nr.ToString(), cmdr.Name);
                _db.PutSettingString("EDCommanderApiKey" + cmdr.Nr.ToString(), cmdr.APIKey);
                _db.PutSettingString("EDCommanderNetLogPath" + cmdr.Nr.ToString(), cmdr.NetLogPath);
            }

            LoadCommanders();
        }

        internal EDCommander GetNewCommander()
        {
            int maxnr = 1;
            foreach (EDCommander cmdr in listCommanders)
            {
                maxnr = Math.Max(cmdr.Nr, maxnr);
            }

            return new EDCommander(maxnr+1, "CMDR "+(maxnr + 1).ToString(), "");
        }
    }
}
