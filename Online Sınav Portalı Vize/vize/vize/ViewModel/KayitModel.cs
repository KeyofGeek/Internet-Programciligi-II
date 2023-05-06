using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vize.ViewModel
{
    public class KayitModel
    {
        public string kayId { get; set; }
        public string kaySorId { get; set; }
        public string kaySecId { get; set; }
        public SoruModel soruBilgi { get; set; }
        public CevapModel cevapBilgi { get; set; }
    }
}