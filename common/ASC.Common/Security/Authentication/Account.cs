using System;

namespace ASC.Common.Security.Authentication
{
    [Serializable]
    public class Account : IAccount
    {
        public Account(Guid id, string name, bool authenticated)
        {
            ID = id;
            Name = name;
            IsAuthenticated = authenticated;
        }

        #region IAccount Members

        public Guid ID { get; private set; }

        public string Name { get; private set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

        public string AuthenticationType
        {
            get { return "ASC"; }
        }

        public virtual bool IsAuthenticated
        {
            get;
            private set;
        }

        #endregion

        public override bool Equals(object obj)
        {
            var a = obj as IAccount;
            return a != null && ID.Equals(a.ID);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}