using System;

namespace Task_2
{
	class Program
	{
		static UInt16 CalculateBusinessDays(DateTime startDate, DateTime endDate)
		{
			UInt16 calcBusinessDays = (UInt16)(1 + ((endDate - startDate).TotalDays * 5 -
									(startDate.DayOfWeek - endDate.DayOfWeek) * 2) / 7);

			if (endDate.DayOfWeek == DayOfWeek.Saturday)
				calcBusinessDays--;
			if (startDate.DayOfWeek == DayOfWeek.Sunday)
				calcBusinessDays--;

			return (calcBusinessDays);
		}

		static void Main(string[] args)
		{
			double advancePercent;
			UInt16 minWorkDaysPerMonth, dayOfAdvancePayment, salary, planWorkDays, workDays;
			string companyName;

			Console.Write("Введите название компании: ");
			companyName = Console.ReadLine();
			Console.Write("Введите процент аванса, выплачиваемый компанией: ");
			advancePercent = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите минимальное количество отработанных дней для получения аванса: ");
			minWorkDaysPerMonth = Convert.ToUInt16(Console.ReadLine());
			Console.Write("Введите день выплаты аванса: ");
			dayOfAdvancePayment = Convert.ToUInt16(Console.ReadLine());

			Company SberSolutions = new Company(companyName, advancePercent, minWorkDaysPerMonth, dayOfAdvancePayment);
			Console.WriteLine();

			Console.Write("Введите зарплату сотрудника: ");
			salary = Convert.ToUInt16(Console.ReadLine());
			Console.Write("Введите количество дней отработанных сотрудником за этот месяц: ");
			workDays = Convert.ToUInt16(Console.ReadLine());

			Worker Nikita = new Worker(SberSolutions, salary);

			planWorkDays = CalculateBusinessDays(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)));
			Console.WriteLine(SberSolutions.dayOfAdvancePayment + " числа сотрудник компании \"" + Nikita.workPlace.name + "\" получит аванс в размере " + Nikita.CalculateAdvancePayment(planWorkDays, workDays) + " рублей.");
		}
	}
}
