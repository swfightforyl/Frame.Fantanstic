﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class CheckBox : FantasticHelperBase
    {
        private string _id = string.Empty;
        private string _name = string.Empty;
        private string _value = string.Empty;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();

        public CheckBox ID(string id)
        {
            this._id = id;
            return this;
        }
   
        public CheckBox Name(string name)
        {
            this._name = name;
            return this;
        }
        public CheckBox Value(string value)
        {
            this._value = value;
            return this;
        }

        public override string Render()
        {
            if (string.IsNullOrEmpty(this._id))
            {
                this._id = "checkbox_" + Guid.NewGuid().ToString("D"); //唯一ID的生成               
            }
            _dicHtmlAttributes.Add("id", this._id);
            _dicHtmlAttributes.Add("type", "checkbox");       
            _dicHtmlAttributes.Fill("value", _value);
          
            return string.Format("<input {0} />", _dicHtmlAttributes.DicToHtmlAttr());
        }
    }
}
