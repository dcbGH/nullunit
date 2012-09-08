// Copyright (c) 2011-2012, Jonathan Clark
// All rights reserved.
//
// This software is licensed under the two-clause Simplified BSD License.
// The text of this license is available from:
// http://www.opensource.org/licenses/bsd-license.php

#ifndef _T_UNCOPYABLE_H_INCLUDED_
#define _T_UNCOPYABLE_H_INCLUDED_

namespace NullUnit
{
	class Uncopyable
	{
	protected:
		Uncopyable()
		{
			return;
		}

		virtual ~Uncopyable()
		{
			return;
		}

	private:
		Uncopyable(const Uncopyable&);
		const Uncopyable& operator=(const Uncopyable&);
	};
}

#endif // _T_UNCOPYABLE_H_INCLUDED_
