﻿#region License

//
// Author: Javier Lozano <javier@lozanotek.com>
// Copyright (c) 2009-2010, lozanotek, inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#endregion

namespace MvcTurbine.NHibernate {
	using System.Linq;
	using global::NHibernate;
	using global::NHibernate.Linq;
	using Data;

	public class GenericRepository<T> : RepositoryBase<T> {
		public virtual ISessionProvider SessionProvider { get; set; }

		public override IQueryable<T> LinqAdapter() {
			ISession session = GetSession();
			return session.Linq<T>();
		}

		public override void Add(T entity) {
			ISession session = GetSession();
			session.SaveOrUpdate(entity);
		}

		public override void Remove(T entity) {
			ISession session = GetSession();
			session.Delete(entity);
		}

		protected virtual ISession GetSession() {
			return SessionProvider.CurrentSession;
		}
	}
}