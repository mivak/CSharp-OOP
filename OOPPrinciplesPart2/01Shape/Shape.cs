﻿namespace Shape
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get 
            {
                return this.width;
            }
    
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width should be greater than zero");
                }
            
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height should be greater than zero");
                }
            
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}