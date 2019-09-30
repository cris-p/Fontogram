﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace PergleLabs.UI
{


    public class BindingProperty
        : INotifyPropertyChanged
    {
        string _val;

        public string Val
        {
            get { return _val; }
            set
            {
                _val = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Val"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    abstract class TranslatedProperty
        : BindingProperty
    {
        public readonly string InDefault;

        public TranslatedProperty(string def)
        {
            InDefault = def;
        }

        public string In
        {
            set
            {
                string newIn =
                    string.IsNullOrWhiteSpace(value)
                    ? InDefault
                    : value; 

                Val = Translate(newIn);
            }
        }

        protected abstract string Translate(string inVal);
    }

    class CopiedProperty
        : TranslatedProperty
    {
        public CopiedProperty(string def)
            : base(def)
        { }

        protected override string Translate(string inVal)
        {
            return inVal;
        }
    }

    interface ControlSizeNotifier
    {
        event Action<double> HeightUpdated;
        event Action<double> WidthUpdated;
    }

    class RelsizeProperty
        : TranslatedProperty
    {
        private readonly int _DefaultRelsize = 0;

        private readonly Action<double> _ActionOnChange;

        private readonly Action<double> _NullAction = ((newVal) => { });

        public RelsizeProperty(string relDefault, ControlSizeNotifier sizeNotifier, Action<double> actionOnChange = null)
            : base(relDefault)
        {
            int.TryParse(relDefault, out _DefaultRelsize);

            _ActionOnChange = actionOnChange == null ? _NullAction : actionOnChange;

            sizeNotifier.HeightUpdated += SizeNotifier_HeightUpdated;

            this.PropertyChanged += RelsizeProperty_PropertyChanged;
        }

        private void RelsizeProperty_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            double newVal = double.Parse(this.Val);

            _ActionOnChange(newVal);
        }

        private double _currControlHeight = 0;
        private string _currInVal; 

        private void SizeNotifier_HeightUpdated(double newHeight)
        {
            if (newHeight == _currControlHeight)
                return;

            _currControlHeight = newHeight;
            Val = Translate(_currInVal);
        }

        protected override string Translate(string inVal)
        {
            int newRelVal;

            if (int.TryParse(inVal, out newRelVal))
                _currInVal = inVal;
            else
                newRelVal = _DefaultRelsize;

            double newVal = _currControlHeight * newRelVal / 100;

            return newVal.ToString("f1");
        }
    }


    class MarginProperty
        : BindingProperty
    {

        public double ShiftX
        {
            set { _currShiftX = value; SetVal(); }
        }
        public double ShiftY
        {
            set { _currShiftY = value; SetVal(); }
        }


        public MarginProperty()
        {
            SetVal();
        }

        private double _currShiftX = 0;
        private double _currShiftY = 0;

        private void SetVal()
        {
            double l = 0, t = 0, r = 0, b = 0;

            if (_currShiftX > 0)
                r -= 2 * _currShiftX;
            else
                l += 2 * _currShiftX;

            if (_currShiftY > 0)
                b -= 2 * _currShiftY;
            else
                t += 2 * _currShiftY;

            Val = string.Format("{0:f1},{1:f1},{2:f1},{3:f1}", l, t, r, b);
        }

    }


    class RecipeBindingProps
        : ControlSizeNotifier
    {

        #region Defaults (in original units)

        const string DEF_Text = ""; // no text //😀
        const string DEF_TextFont = "Segoe UI Emoji";
        const string DEF_TextFontWeight = "Normal";
        const string DEF_TextColor = "Black";
        const string DEF_TextFontSize = "100";
        const string DEF_TextShiftX = "0";
        const string DEF_TextShiftY = "0";
        const string DEF_TextRotAngle = "0";
        const string DEF_TextScaleX = "1";
        const string DEF_TextScaleY = "1";
        const string DEF_TextSkewX = "0";
        const string DEF_TextSkewY = "0";


        const string DEF_BackOpacity = "1";
        const string DEF_BackFillColor = "Transparent"; // no backdrop
        const string DEF_BackStrokeThickness = "0";  // no border
        const string DEF_BackStrokeColor = "Black";
        const string DEF_BackWidth = "100"; // percentages relative to control *height*
        const string DEF_BackHeight = "100";
        const string DEF_BackShiftX = "0";
        const string DEF_BackShiftY = "0";
        const string DEF_BackCornerRadius = "10,10,10,10";   // slightly rounded        
        const string DEF_BackRotAngle = "0";
        const string DEF_BackScaleX = "1";
        const string DEF_BackScaleY = "1";
        const string DEF_BackSkewX = "0";
        const string DEF_BackSkewY = "0";

        #endregion


        public RecipeBindingProps()
        {
            // TEXT

            Text = new CopiedProperty(DEF_Text);
            TextFont = new CopiedProperty(DEF_TextFont);
            TextFontWeight = new CopiedProperty(DEF_TextFontWeight);
            TextColor = new CopiedProperty(DEF_TextColor);
            TextFontSize = new RelsizeProperty(DEF_TextFontSize, this);
            TextMargin = new MarginProperty();
            TextShiftX = new RelsizeProperty(DEF_TextShiftX, this, (val) => TextMargin.ShiftX = val);
            TextShiftY = new RelsizeProperty(DEF_TextShiftY, this, (val) => TextMargin.ShiftY = val);
            TextRotAngle = new CopiedProperty(DEF_TextRotAngle);
            TextScaleX = new CopiedProperty(DEF_TextScaleX);
            TextScaleY = new CopiedProperty(DEF_TextScaleY);
            TextSkewX = new CopiedProperty(DEF_TextSkewX);
            TextSkewY = new CopiedProperty(DEF_TextSkewY);


            // BACKDROP

            BackOpacity = new CopiedProperty(DEF_BackOpacity);
            BackFillColor = new CopiedProperty(DEF_BackFillColor);
            BackStrokeThickness = new CopiedProperty(DEF_BackStrokeThickness);
            BackStrokeColor = new CopiedProperty(DEF_BackStrokeColor);
            BackWidth = new RelsizeProperty(DEF_BackWidth, this);
            BackHeight = new RelsizeProperty(DEF_BackHeight, this);
            BackMargin = new MarginProperty();
            BackShiftX = new RelsizeProperty(DEF_BackShiftX, this, (val) => BackMargin.ShiftX = val);
            BackShiftY = new RelsizeProperty(DEF_BackShiftY, this, (val) => BackMargin.ShiftY = val);
            BackCornerRadius = new CopiedProperty(DEF_BackCornerRadius);    // !!!
            BackRotAngle = new CopiedProperty(DEF_BackRotAngle);
            BackScaleX = new CopiedProperty(DEF_BackScaleX);
            BackScaleY = new CopiedProperty(DEF_BackScaleY);
            BackSkewX = new CopiedProperty(DEF_BackSkewX);
            BackSkewY = new CopiedProperty(DEF_BackSkewY);
        }


        #region Fontogram properties resolved to actual control properties

        #region Text

        public TranslatedProperty Text { get; }

        #region TextAttr

        public TranslatedProperty TextFont { get; }

        public TranslatedProperty TextFontWeight { get; }

        public TranslatedProperty TextColor { get; }

        #endregion

        #region TextPosRel

        public TranslatedProperty TextFontSize { get; }

        public MarginProperty TextMargin { get; }   // updated indirectly, via Shift properties

        public TranslatedProperty TextShiftX { get; }
        public TranslatedProperty TextShiftY { get; }

        #endregion

        #region TextTransform

        public TranslatedProperty TextRotAngle { get; }

        public TranslatedProperty TextScaleX { get; }
        public TranslatedProperty TextScaleY { get; }

        public TranslatedProperty TextSkewX { get; }
        public TranslatedProperty TextSkewY { get; }

        #endregion

        #endregion


        #region Backdrop

        #region BackAttr

        public TranslatedProperty BackOpacity { get; }

        public TranslatedProperty BackFillColor { get; }

        public TranslatedProperty BackStrokeThickness { get; }

        public TranslatedProperty BackStrokeColor { get; }

        #endregion

        #region BackPosRel

        public TranslatedProperty BackWidth { get; }
        public TranslatedProperty BackHeight { get; }

        public MarginProperty BackMargin { get; }   // updated indirectly, via Shift properties

        public TranslatedProperty BackShiftX { get; }
        public TranslatedProperty BackShiftY { get; }

        #endregion

        #region BackCorderRadiusRel

        public TranslatedProperty BackCornerRadius { get; }

        #endregion

        #region BackTransform

        public TranslatedProperty BackRotAngle { get; }

        public TranslatedProperty BackScaleX { get; }
        public TranslatedProperty BackScaleY { get; }

        public TranslatedProperty BackSkewX { get; }
        public TranslatedProperty BackSkewY { get; }

        #endregion

        #endregion

        #endregion


        public event Action<double> HeightUpdated;
        public event Action<double> WidthUpdated;

        public void OnControlSizeChanged(double width, double height)
        {
            this.HeightUpdated?.Invoke(height);
            this.WidthUpdated?.Invoke(width);
        }

    }

}