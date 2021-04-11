using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web
{
    /// <summary>
    /// Сводное описание для Liter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
public class Liter : System.Web.Services.WebService
    {

        [WebMethod]
        public string ChangeVolumeWeight(double value, VolumesWeights From, VolumesWeights To )
        {
            string res="";
            switch(From)  
            {
                case VolumesWeights.liter:
                    res = LiterToSMT(value, To);
                    break;
                case VolumesWeights.deciliter:
                    res = DeciLiterToSMT(value, To);
                    break;
                case VolumesWeights.centiliter:
                    res = CentiliterToSMT(value, To);
                    break;
                case VolumesWeights.milliliter:
                    res = MilliliterToSMT(value, To);
                    break;
                case VolumesWeights.cubicmeter:
                    res = CubicmeterToSMT(value, To);
                    break;
                case VolumesWeights.cubicdecimeter:
                    res = CubicdeciToSMT(value, To);
                    break;
                case VolumesWeights.cubiccentimeter:
                    res = CubiccentiToSMT(value, To);
                    break;
                case VolumesWeights.cubicmillimeter:
                    res = CubicmilliToSMT(value, To);
                    break;
                case VolumesWeights.hectoliter:
                    res = hectoliterToSMT(value, To);
                    break;
                case VolumesWeights.decaliter:
                    res = decaliterToSMT(value, To);
                    break;
            }

            return res;
        }
        public string LiterToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {
            
                case VolumesWeights.cubicmeter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value*1;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 1000000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.liter:
                    Res = value ;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 10;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 100;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 1000;
                    break;
              
            }
            
            return Convert.ToString(Res);
        }
        public string DeciLiterToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {
              
                case VolumesWeights.cubicmeter:
                    Res = value * 0.0001;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 100;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 100000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.liter:
                    Res = value*0.1;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 1;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 10;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 100;
                    break;
            
            }

            return Convert.ToString(Res);
        }
        public string CentiliterToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {
               
                case VolumesWeights.cubicmeter:
                    Res = value * 0.00001;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 10;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 10000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.0001;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.liter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 1;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 10;
                    break;
              
            }

            return Convert.ToString(Res);
        }
        public string MilliliterToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {
               
                case VolumesWeights.cubicmeter:
                    Res = value * 0.000001;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 1;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.00001;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 0.0001;
                    break;
                case VolumesWeights.liter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 1;
                    break;
               
            }

            return Convert.ToString(Res);
        }
        public string CubicmeterToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {
              
                case VolumesWeights.cubicmeter:
                    Res = value * 1;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 1000000;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 1000000000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 10;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 100;
                    break;
                case VolumesWeights.liter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 10000;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 100000;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 1000000;
                    break;
                
            }

            return Convert.ToString(Res);
        }
        public string CubicdeciToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {

                case VolumesWeights.cubicmeter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 1;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 1000000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.liter:
                    Res = value * 1;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 10;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 100;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 1000;
                    break;

            }

            return Convert.ToString(Res);
        }
        public string CubiccentiToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {

                case VolumesWeights.cubicmeter:
                    Res = value * 0.000001;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 1;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.00001;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 0.0001;
                    break;
                case VolumesWeights.liter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 1;
                    break;

            }

            return Convert.ToString(Res);
        }
        public string CubicmilliToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {

                case VolumesWeights.cubicmeter:
                    Res = value * 0.000000001;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 0.000001;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 0.001;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 1;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.00000001;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 0.0000001;
                    break;
                case VolumesWeights.liter:
                    Res = value * 0.000001;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 0.00001;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 0.0001;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 0.001;
                    break;

            }

            return Convert.ToString(Res);
        }
        public string hectoliterToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {

                case VolumesWeights.cubicmeter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 100;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 100000;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 100000000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 1;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 10;
                    break;
                case VolumesWeights.liter:
                    Res = value * 100;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 10000;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 100000;
                    break;

            }

            return Convert.ToString(Res);
        }
        public string decaliterToSMT(double value, VolumesWeights To)
        {
            double Res = 0.0;
            switch (To)
            {

                case VolumesWeights.cubicmeter:
                    Res = value * 0.01;
                    break;
                case VolumesWeights.cubicdecimeter:
                    Res = value * 10;
                    break;
                case VolumesWeights.cubiccentimeter:
                    Res = value * 10000;
                    break;
                case VolumesWeights.cubicmillimeter:
                    Res = value * 10000000;
                    break;
                case VolumesWeights.hectoliter:
                    Res = value * 0.1;
                    break;
                case VolumesWeights.decaliter:
                    Res = value * 1;
                    break;
                case VolumesWeights.liter:
                    Res = value * 10;
                    break;
                case VolumesWeights.deciliter:
                    Res = value * 100;
                    break;
                case VolumesWeights.centiliter:
                    Res = value * 1000;
                    break;
                case VolumesWeights.milliliter:
                    Res = value * 10000;
                    break;

            }

            return Convert.ToString(Res);
        }
        public enum VolumesWeights
        {
            
            cubicmeter,
            cubicdecimeter,
            cubiccentimeter,
            cubicmillimeter,
            hectoliter,
            decaliter,
            liter,
            deciliter,
            centiliter,
            milliliter,
            
        }
    }
}
