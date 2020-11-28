using Microsoft.AspNetCore.Mvc;

namespace SimpleCalcApp
{
    [Route("[controller]")]
    public class CalculatorController : Controller
    {

        private readonly ICalcService _calcService;

        public CalculatorController()
        {
            _calcService = new CalcService();
        }

        [Route("sum")]
        public IActionResult Add(CalcOperation model)
        {
            model.Result = _calcService.Sum(model.Number1, model.Number2);
            return Json(model);
        }

        [Route("subtract")]
        public IActionResult Subtract(CalcOperation model)
        {
            model.Result = _calcService.Subtract(model.Number1, model.Number2);
            return Json(model);
        }

        [Route("multiply")]
        public IActionResult Multiply(CalcOperation model)
        {
            model.Result = _calcService.Multiply(model.Number1, model.Number2);
            return Json(model);
        }

        [Route("divide")]
        public IActionResult Divide(CalcOperation model)
        {
            model.Result = _calcService.Divide(model.Number1, model.Number2);
            return Json(model);
        }


   

        
    }
}