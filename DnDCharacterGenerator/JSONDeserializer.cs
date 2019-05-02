using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DnDCharacterGenerator
{
    class JSONDeserializer
    {
        private string _strReturnValue;
        public string strReturnValue
        {
            get { return _strReturnValue; }
            set { _strReturnValue = value; }
        }

        public void deserializeJSON(string strJSON, string target)
        {
            try
            {
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                debugOutput(target);

            }
            catch(Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
