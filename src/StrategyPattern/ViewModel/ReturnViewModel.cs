using System;
namespace StrategyPattern.ViewModel
{
    public class ReturnViewModel
    {
        public ReturnViewModel(bool success, string message, object returnObject = null)
        {
            Success = success;
            Message = message;
            ReturnObject = returnObject;
        }

        public bool Success { get; set; }
        public object ReturnObject { get; set; }
        public string Message { get; set; }
    }
}
