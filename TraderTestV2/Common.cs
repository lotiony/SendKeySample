using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraderTestV2.Model;
using System.Web.Script.Serialization;
using System.IO;

namespace TraderTestV2
{
    public class Common
    {
        public static readonly string SettingFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.json");

        public static void SaveSetting(Setting set)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string jsonString = ser.Serialize(set);

            File.WriteAllText(SettingFile, jsonString);
        }

        public static Setting LoadSetting()
        {
            if (File.Exists(SettingFile))
            {
                string jsonString = File.ReadAllText(SettingFile);
                try
                {
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    Setting setting = ser.Deserialize<Setting>(jsonString);

                    return setting;
                }
                catch (Exception)
                {
                    return new Setting();
                }
            }
            else
                return new Setting();
            

        }
    }
}
