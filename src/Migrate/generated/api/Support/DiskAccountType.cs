// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The disk type.</summary>
    public partial struct DiskAccountType :
        System.IEquatable<DiskAccountType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType PremiumLrs = @"Premium_LRS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType StandardLrs = @"Standard_LRS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType StandardSsdLrs = @"StandardSSD_LRS";

        /// <summary>the value for an instance of the <see cref="DiskAccountType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DiskAccountType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DiskAccountType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DiskAccountType(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DiskAccountType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DiskAccountType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DiskAccountType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DiskAccountType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DiskAccountType && Equals((DiskAccountType)obj);
        }

        /// <summary>Returns hashCode for enum DiskAccountType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DiskAccountType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DiskAccountType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DiskAccountType" />.</param>

        public static implicit operator DiskAccountType(string value)
        {
            return new DiskAccountType(value);
        }

        /// <summary>Implicit operator to convert DiskAccountType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DiskAccountType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DiskAccountType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DiskAccountType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType e2)
        {
            return e2.Equals(e1);
        }
    }
}