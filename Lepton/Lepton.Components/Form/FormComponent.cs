using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lepton.Components.Form
{
    public abstract class FormComponent<TValue> : ComponentBase
    {
        [Parameter]
        public bool Enabled { get; set; } = true;

        [Parameter]
        public TValue Value { get; set; }

        [Parameter]
        public virtual Func<TValue, bool> Validator { get; set; } = null;

        public bool IsValid => Validate();

        public virtual bool Validate()
        {
            if (Validator is null)
                return true;

            return Validator(Value);
        }
    }
}
