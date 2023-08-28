using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveDirectorySynchronization
{
    public class ADManager
    {



        PrincipalContext context;

        private String DomainKey
        {

            get
            {

                return ConfigurationManager.AppSettings["DomainKey"];

            }

        }

        private String LDAPUser
        {

            get
            {

                return ConfigurationManager.AppSettings["LDAPUser"];

            }

        }



        private String LDAPPassword
        {

            get
            {

                return ConfigurationManager.AppSettings["LDAPPassword"];

            }

        }

        public ADManager()
        {

            context = new PrincipalContext(ContextType.Machine, DomainKey, LDAPUser, LDAPPassword);



        }





        public ADManager(string domain, string container)
        {

            context = new PrincipalContext(ContextType.Domain, domain, container);

        }



        public ADManager(string domain, string username, string password)
        {

            context = new PrincipalContext(ContextType.Domain, username, password);

        }



        public bool AddUserToGroup(string userName, string groupName)
        {

            bool done = false;

            GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName);

            if (group == null)
            {

                group = new GroupPrincipal(context, groupName);

            }

            UserPrincipal user = UserPrincipal.FindByIdentity(context, userName);

            if (user != null & group != null)
            {

                group.Members.Add(user);

                group.Save();

                done = (user.IsMemberOf(group));

            }

            return done;

        }





        public bool RemoveUserFromGroup(string userName, string groupName)
        {

            bool done = false;

            UserPrincipal user = UserPrincipal.FindByIdentity(context, userName);

            GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName);

            if (user != null & group != null)
            {

                group.Members.Remove(user);

                group.Save();

                done = !(user.IsMemberOf(group));

            }

            return done;

        }

    }

}


