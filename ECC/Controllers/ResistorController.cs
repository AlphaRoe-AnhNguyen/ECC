using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECC.Core.Enums;
using ECC.Models;
using ECC.Core.Interfaces;

namespace ECC.Controllers
{
    public class ResistorController : Controller
    {
        private IOhmValueCalculator _resistorCal;
        public ResistorController(IOhmValueCalculator resistorCal)
        {
            _resistorCal = resistorCal;
        }

        public ActionResult Index()
        {
            var model = new ResistorViewModels();
            model.ComponentValues = GetSelectListItems();
            model.TolenranceValues = GetToleranceSelectListItem();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ResistorViewModels model)
        {
            var realValue = _resistorCal.RealCalculateOhmValue(model.BandA.ToString(), model.BandB.ToString(), model.BandC.ToString(), model.BandD.ToString());
            model.ComponentValues = GetSelectListItems();
            model.TolenranceValues = GetToleranceSelectListItem();

            if (ModelState.IsValid)
            {
                model.ResistorValue = _resistorCal.CalculateOhmValue(model.BandA.ToString(), model.BandB.ToString(), model.BandC.ToString());
                model.ResistorMinValue = realValue.Item1;
                model.ResistorMaxValue = realValue.Item2;
            }


            return View(model);
        }

        private IEnumerable<SelectListItem> GetToleranceSelectListItem()
        {
            var selectList = new List<SelectListItem>();

            var enumValues = Enum.GetValues(typeof(ColorEnum)) as ColorEnum[];
            if (enumValues == null)
                return null;

            foreach (var enumValue in enumValues)
            {
                if ((int)enumValue < 0)
                {
                    selectList.Add(new SelectListItem
                    {
                        Value = enumValue.ToString(),
                        Text = enumValue.ToString()
                    });
                }

            }

            return selectList;
        }


        private IEnumerable<SelectListItem> GetSelectListItems()
        {
            var selectList = new List<SelectListItem>();

            var enumValues = Enum.GetValues(typeof(ColorEnum)) as ColorEnum[];
            if (enumValues == null)
                return null;

            foreach (var enumValue in enumValues)
            {
                if ((int)enumValue >= 0)
                {
                    selectList.Add(new SelectListItem
                    {
                        Value = enumValue.ToString(),
                        Text = enumValue.ToString()
                    });
                }
            }

            return selectList;
        }
    }
}