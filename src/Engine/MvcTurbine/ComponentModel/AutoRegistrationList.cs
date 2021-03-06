﻿namespace MvcTurbine.ComponentModel {
    using System;
    using System.Collections;
    using System.Collections.Generic;

    ///<summary>
    /// Defines a list of auto-registrations for the system process.
    ///</summary>
    [Serializable]
    public class AutoRegistrationList : IEnumerable<ServiceRegistration> {

        private readonly List<ServiceRegistration> registrationList;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public AutoRegistrationList() {
            registrationList = new List<ServiceRegistration>();
        }

        /// <summary>
        /// Adds the specified <see cref="ServiceRegistration"/>
        /// </summary>
        /// <param name="registration"></param>
        /// <returns></returns>
        public AutoRegistrationList Add(ServiceRegistration registration) {
            registrationList.Add(registration);
            return this;
        }

        /// <summary>
        /// Clears the current list.
        /// </summary>
        public void Clear() {
            registrationList.Clear();
        }

        /// <summary>
        /// Gets the enumerator of <seealso cref="ServiceRegistration"/>.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<ServiceRegistration> GetEnumerator() {
            return registrationList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}