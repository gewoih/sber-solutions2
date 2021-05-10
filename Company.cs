using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
	class Company
	{
		public string name { get; } = "";
		public double advancePercent { get; } = 0;
		public UInt16 minWorkDaysPerMonth { get; } = 0;
		public UInt16 dayOfAdvancePayment { get; } = 0;

		public Company(string name, double advancePercent, UInt16 minWorkDaysPerMonth, UInt16 dayOfAdvancePayment)
		{
			this.name = name;
			this.advancePercent = advancePercent;
			this.minWorkDaysPerMonth = minWorkDaysPerMonth;
			this.dayOfAdvancePayment = dayOfAdvancePayment;
		}
	}
}
