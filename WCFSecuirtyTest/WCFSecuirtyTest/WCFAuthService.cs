using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSecuirtyTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFAuthService" in both code and config file together.
    public class WCFAuthService : IWCFAuthService
    {
        public string GetUserName()
        {
            string a = "Is Authencticated" + ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated;
            string b = "Authentication type" + ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType;
            string c = "User Name" + ServiceSecurityContext.Current.PrimaryIdentity.Name;
            return a +"--"+ b + "--" + c;
        }
    }
}
