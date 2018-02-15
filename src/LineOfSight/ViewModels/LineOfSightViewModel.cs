﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Autodesk.Revit.DB;
using Caliburn.Micro;

namespace SCaddins.LineOfSight.ViewModels
{
    class LineOfSightViewModel : PropertyChangedBase,  INotifyDataErrorInfo

    {
        private Dictionary<string, string> validationErrors;

        public double TreadSize
        {
            get
            {
                return lineOfSight.TreadSize;
            }
            set
            {
                lineOfSight.TreadSize = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }

        public double EyeHeight
        {
            get
            {
                return lineOfSight.EyeHeight;
            }
            set
            {
                lineOfSight.EyeHeight = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }

        public double DistanceToFirstRowX
        {
            get
            {
                return lineOfSight.DistanceToFirstRowX;
            }
            set
            {
                lineOfSight.DistanceToFirstRowX = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }

        public double DistanceToFirstRowY
        {
            get
            {
                return lineOfSight.DistanceToFirstRowY;
            }
            set
            {
                lineOfSight.DistanceToFirstRowY = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }


        public int NumberOfRows
        {
            get
            {
                return lineOfSight.NumberOfRows;
            }
            set
            {
                lineOfSight.NumberOfRows = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }

        public double MinimumRiserHeight
        {
            get
            {
                return lineOfSight.MinimumRiserHeight;
            }
            set
            {
                lineOfSight.MinimumRiserHeight = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }

        public double MinimumCValue
        {
            get
            {
                return lineOfSight.MinimumCValue;
            }
            set
            {
                lineOfSight.MinimumCValue = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }

        public double RiserIncrement
        {
            get
            {
                return lineOfSight.RiserIncrement;
            }
            set
            {
                lineOfSight.RiserIncrement = value;
                NotifyOfPropertyChange(() => InfoString);
            }
        }

        public string InfoString
        {
            get
            {
                return lineOfSight.InfoString;
            }
        }

        public void Draw()
        {
            validationErrors = new Dictionary<string, string>();
            lineOfSight.Draw();
        }

        public IEnumerable GetErrors(string propertyName)
        {
            string value;
            if (validationErrors.TryGetValue(propertyName, out value))
                return new List<string>(1) { value };

            return null;

        }

        public bool CanDraw
        {
            get
            {
                return false;
            }
        }

        public bool HasErrors => throw new NotImplementedException();

        private LineOfSight lineOfSight;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public LineOfSightViewModel(Document doc)
        {
            lineOfSight = new LineOfSight(doc);
        }
    }
}