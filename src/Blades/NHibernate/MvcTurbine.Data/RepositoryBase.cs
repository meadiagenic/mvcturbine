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

namespace MvcTurbine.Data {
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;

	public abstract class RepositoryBase<T> : IRepository<T> {
		public IEnumerator<T> GetEnumerator() {
			return LinqAdapter().AsEnumerable().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}

		public Expression Expression {
			get { return LinqAdapter().Expression; }
		}

		public Type ElementType {
			get { return LinqAdapter().ElementType; }
		}

		public IQueryProvider Provider {
			get { return LinqAdapter().Provider; }
		}

		public abstract void Add(T entity);
		public abstract void Remove(T entity);
	    public abstract void Update(T entity);

	    public abstract IQueryable<T> LinqAdapter();
	}
}