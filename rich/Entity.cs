using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace rich
{
    public abstract class Entity : Notifiable
    {
        public virtual int Id { get; protected set; }
        protected virtual object Actual => this;

        public override bool Equals(object obj)
        {
            var other = obj as Entity;

            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (Actual.GetType() != other.Actual.GetType())
                return false;

            if (Id == 0 || other.Id == 0)
                return false;

            return Id == other.Id;
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (Actual.GetType().ToString() + Id).GetHashCode();
        }
    }
}
