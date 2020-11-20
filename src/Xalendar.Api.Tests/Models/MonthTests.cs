﻿using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xalendar.Api.Models;

namespace Xalendar.Api.Tests.Models
{
    [TestFixture]
    public class MonthTests
    {
        [Test]
        public void November2020ShouldContain30Days()
        {
            var dateTime = new DateTime(2020, 11, 1);
            var month = new Month(dateTime);

            var result = month.GetDaysOfMonth();

            Assert.AreEqual(30, result.Count);
        }

        [Test]
        public void LeapYearFebruaryShouldContain29Days()
        {
            var dateTime = new DateTime(2020, 2, 1);
            var month = new Month(dateTime);

            var result = month.GetDaysOfMonth();

            Assert.AreEqual(29, result.Count);
        }

        [Test]
        public void ShouldNotExistSelectedDay()
        {
            var dateTime = new DateTime(2020, 2, 1);
            var month = new Month(dateTime);

            var selectedDay = month.GetSelectedDay();

            Assert.IsNull(selectedDay);
        }

        [Test]
        public void SelectedDayShouldBeToday()
        {
            var dateTime = DateTime.Today;
            var month = new Month(dateTime);
            var isSelected = true;
            var day = new Day(dateTime, isSelected);
            month.SelectDay(day);

            var selectedDay = month.GetSelectedDay();

            //Assert.AreEqual(day, selectedDay);
            Assert.AreEqual(day.DateTime.Date.Ticks, selectedDay.DateTime.Date.Ticks);
        }

        [Test]
        public void SelectedDayShouldBeChanged()
        {

        }
    }
}
