﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [DataContract]
    public class TemplateSchedule
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int NoOfWeeks { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int DepartmentId { get; set; }

        [DataMember]
        public List<TemplateShift> ListOfTempShifts { get; set; }

        public TemplateSchedule(int numberOfWeeks, string name)
        {
            NoOfWeeks = numberOfWeeks;
            Name = name;
            ListOfTempShifts = new List<TemplateShift>();
        }
        public TemplateSchedule(int id, string name, int numberOfWeeks, int departmentId)
        {
            ListOfTempShifts = new List<TemplateShift>();
            Id = id;
            NoOfWeeks = numberOfWeeks;
            Name = name;
            DepartmentId = departmentId;
            ListOfTempShifts = new List<TemplateShift>();
        }

        public TemplateSchedule(int numberOfWeeks, string name, int departmentId)
        {
            ListOfTempShifts = new List<TemplateShift>();
            NoOfWeeks = numberOfWeeks;
            Name = name;
            DepartmentId = departmentId;
            ListOfTempShifts = new List<TemplateShift>();
        }

        public TemplateSchedule()
        {
            ListOfTempShifts = new List<TemplateShift>();
        }
    }
}
