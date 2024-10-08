﻿namespace SearchForPets.Domain.Entities.Common
{
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;
            if (obj is not ValueObject valueObject) return false;
            else return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
        }

        public override int GetHashCode() => GetEqualityComponents().Aggregate(default(int), (hashcode, value) => 
        HashCode.Combine(hashcode, value.GetHashCode()));

        public static bool operator ==(ValueObject? left, ValueObject? right)
        {
            if(left is null && right is null)
                return true;
            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(ValueObject left, ValueObject right) => !(left == right);
    }
}
