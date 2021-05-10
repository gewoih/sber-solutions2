using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
	class Worker
	{
		public Company workPlace { get; }
		UInt32 salary = 0;

		public Worker(Company workPlace, UInt16 salary)
		{
			this.workPlace = workPlace;
			this.salary = salary;
		}

		public double CalculateAdvancePayment(UInt16 planWorkDays, UInt16 workDays)
		{
			if (workPlace.minWorkDaysPerMonth > workDays)
				return (0);
			return (salary / planWorkDays * workDays * workPlace.advancePercent / 100);
		}
	}
}
