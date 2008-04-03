using System.Collections.Generic;
using System.Configuration;
using NHibernate.Burrow.Exceptions;
using NHibernate.Burrow.Impl;

namespace NHibernate.Burrow.Configuration {
    /// <summary>
    /// Root Section for NHibernate.Burrow Configuration
    /// </summary>
    public class NHibernateBurrowCfgSection : ConfigurationSection, IBurrowConfig {
        /// <summary>
        /// 
        /// </summary>
        public const string SectionName = "NHibernate.Burrow";

        private static IDictionary<string, object> savedSettings = new Dictionary<string, object>();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Declare a collection element represented 
        /// in the configuration file by the sub-section
        /// <![CDATA[
        /// <persistantUnits> <add .../> </persistantUnits> 
        /// Note: the "IsDefaultCollection = false" 
        /// instructs the .NET Framework to build a nested 
        /// section like <persistantUnits> ...</persistantUnits>.
        /// ]]>
        /// </remarks>
        [ConfigurationProperty("persistantUnits", IsDefaultCollection = false)]
        public PersistenceUnitElementCollection PersistenceUnits {
            get {
                PersistenceUnitElementCollection persistantUnits =
                    (PersistenceUnitElementCollection) base["persistantUnits"];
                return persistantUnits;
            }
        }


        public ICollection<IPersistenceUnitCfg> PersistenceUnitCfgs {
            get {
                IList<IPersistenceUnitCfg> retVal = new List<IPersistenceUnitCfg>();
                foreach (PersistenceUnitElement pue in PersistenceUnits)
                {
                    retVal.Add(pue);
                }
                return retVal;
            }
        }

        ///<summary>
        /// The converstaion timout minutes
        ///</summary>
        [ConfigurationProperty("conversationTimeOut", DefaultValue = "30", IsRequired = false, IsKey = false)]
        public int ConversationTimeOut {
            get { return (int) Get("conversationTimeOut"); }
            set { Set("conversationTimeOut", value); }
        }

        ///<summary>
        /// The conversation clean up frequency,
        ///  for how many times of conversation Timeout,
        ///  the conversation pool clean up its timeoutted converstaions.
        ///  must be greater than 1
        ///</summary>
        [ConfigurationProperty("conversationCleanupFrequency", DefaultValue = "4", IsRequired = false, IsKey = false)]
        public int ConversationCleanupFrequency {
            get { return (int) Get("conversationCleanupFrequency"); }
            set { Set("conversationCleanupFrequency", value); }
        }

        ///<summary>
        /// The conversation clean up frequency,
        ///  for how many times of conversation Timeout,
        ///  the conversation pool clean up its timeoutted converstaions.
        ///  must be greater than 1
        ///</summary>
        [ConfigurationProperty("conversationExpirationChecker", DefaultValue = "", IsRequired = false, IsKey = false)]
        public string ConversationExpirationChecker {
            get { return (string) Get("conversationExpirationChecker"); }
            set { Set("conversationExpirationChecker", value); }
        }

        private void Set(string key, object value) {
            savedSettings[key] = value;
        }

        private object Get(string key) {
            if (savedSettings.ContainsKey(key))
                return savedSettings[key];
            else
                return this[key];
        }

        /// <summary>
        /// Get the instance from the current application's config file
        /// </summary>
        /// <returns></returns>
        public static NHibernateBurrowCfgSection GetInstance() {
            NHibernateBurrowCfgSection section =
                ConfigurationManager.GetSection(SectionName) as NHibernateBurrowCfgSection;
            if (section == null)
                throw new GeneralException("Section \"" + SectionName + "\" is not found");
            return section;
        }

        /// <summary>
        /// Get the DBConnectionString for the DB where <paramref name="entityType"/> is persistent in
        /// </summary>
        /// <returns></returns>
        public string DBConnectionString(System.Type entityType)
        {
            return
                (string)
                PersistenceUnitRepo.Instance.GetPU(entityType).NHConfiguration.Properties[NHibernate.Cfg.Environment.ConnectionString];
        }

      
    }
}