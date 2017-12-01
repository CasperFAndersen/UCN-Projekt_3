﻿using System.Collections.Generic;
using BusinessLogic;
using Core;

namespace ServiceLibrary.TemplateSchedules
{
    public class TemplateScheduleService : ITemplateScheduleService
    {
        TemplateScheduleController templateScheduleController = new TemplateScheduleController();
        public void AddTemplateScheduleToDb(TemplateSchedule templateSchedule)
        {
            templateScheduleController.AddTemplateScheduleToDb(templateSchedule);
        }

        public TemplateSchedule FindTemplateScheduleByName(string name)
        {
            return templateScheduleController.FindTemplateScheduleByName(name);
        }

        public IEnumerable<TemplateSchedule> GetAllTemplateSchedules()
        {
            return templateScheduleController.GetAllTemplateSchedules();
        }
        public void AddTemplateShift(TemplateShift templateShift)
        {
            templateScheduleController.AddTemplateShift(templateShift);
        }

        public void UpdateTemplateSchedule(TemplateSchedule templateSchedule)
        {
            templateScheduleController.UpdateTemplateSchedule(templateSchedule);
        }
    }
}