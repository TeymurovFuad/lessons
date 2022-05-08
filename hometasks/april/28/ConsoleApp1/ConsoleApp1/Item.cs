using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Item
    {
        string marka;
        string model;
        byte year;
        double run;
        string fuelType;
        bool isAutomatic;
        double buyPrice;
        double sellPrice;
        byte discount;
        private double price;

        public Item(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
        }

        public Item(string _marka, string _model, byte _year)
        {
            marka = _marka;
            model = _model;
            year = _year;
        }

        public Item(string _marka, string _model, byte _year, double _run)
        {
            marka = _marka;
            model = _model;
            year = _year;
            run = _run;
        }

        public Item(string _marka, string _model, byte _year, double _run, string _fuelType, bool _isAutomatic, double _buyPrice, double _sellPrice, byte _discount, double _price)
        {
            isAutomatic = _isAutomatic;
            sellPrice = _sellPrice;
            fuelType = _fuelType;
            buyPrice = _buyPrice;
            discount = _discount;
            price = _price;
            marka = _marka;
            model = _model;
            year = _year;
            run = _run;
        }
    }
}
