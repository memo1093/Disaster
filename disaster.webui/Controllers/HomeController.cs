using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using disaster.webui.Models;
using disaster.business.Abstract;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace disaster.webui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IDisasterService _disasterService;
        private ICityService _cityService;
        private ITownService _townService;

        public HomeController(ILogger<HomeController> logger, IDisasterService disasterService, ICityService cityService, ITownService townService)
        {
            _logger = logger;
            _disasterService = disasterService;
            _cityService = cityService;
            _townService = townService;
        }

        public IActionResult Index()
        {
            List<DisasterModel> disasterListModel = new List<DisasterModel>();
            var disasters = _disasterService.GetAll();

            if (disasters.Count() > 0)
            {
                foreach (var disaster in disasters)
                {
                    DisasterModel model = new DisasterModel();
                    model.DisasterId = disaster.DisasterId;
                    model.SerialNo = disaster.SerialNo;
                    model.GlideNo = disaster.GlideNo;
                    model.StartDate = disaster.StartDate;
                    model.FinishDate = disaster.FinishDate;
                    model.DisasterType = disaster.DisasterType;
                    model.Latitute = disaster.Latitute;
                    model.Longtitute = disaster.Longtitute;
                    model.CityName = _cityService.GetById(disaster.CityId).CityName;
                    model.TownName = _townService.GetById(disaster.TownId).TownName;
                    model.Why = disaster.Why;
                    model.Description = disaster.Description;
                    model.AffectedAreas = disaster.AffectedAreas;
                    model.ApproveState = disaster.ApproveState;
                    model.fileNames =  disaster.Sources.Select(i=>i.SourceName).ToList();


                    disasterListModel.Add(model);
                }

            }

            return View(disasterListModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
